using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class TransactionsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public TransactionsController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TransactionDTO>>> GetTransactions()
    {
        var transactions = await _context.Transactions.ToListAsync();
        return _mapper.Map<List<TransactionDTO>>(transactions);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TransactionDTO>> GetTransaction(int id)
    {
        var transaction = await _context.Transactions.FindAsync(id);

        if (transaction == null)
        {
            return NotFound();
        }

        return _mapper.Map<TransactionDTO>(transaction);
    }

    [HttpPost]
    public async Task<ActionResult<TransactionDTO>> PostTransaction(CreateTransactionDTO createTransactionDTO)
    {
        var transaction = _mapper.Map<Transaction>(createTransactionDTO);
        var receiverExists = await _context.Receivers.AnyAsync(r => r.Id == createTransactionDTO.ReceiverId);
        if (!receiverExists) return NotFound("O recebedor especificado não foi encontrado.");
        _context.Transactions.Add(transaction);
        await _context.SaveChangesAsync();

        var transactionDTO = _mapper.Map<TransactionDTO>(transaction);

        return CreatedAtAction(nameof(GetTransaction), new { id = transactionDTO.Id }, transactionDTO);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutTransaction(int id, CreateTransactionDTO createTransactionDTO)
    {
        if (id <= 0)
        {
            return BadRequest();
        }
        var transaction = await _context.Transactions.FindAsync(id);
        if (transaction != null)
        {
            var receiverExists = await _context.Receivers.AnyAsync(r => r.Id == createTransactionDTO.ReceiverId);
            if (!receiverExists) return NotFound("O recebedor especificado não foi encontrado");
            var errors = new List<string>();
            if (transaction.Type != createTransactionDTO.Type)
            {
                var transactionDetails = await _context.TransactionDetails.Where(td => td.TransactionId == id).ToListAsync();
                foreach (var transactionDetail in transactionDetails)
                {
                    var product = await _context.Products.FindAsync(transactionDetail.ProductId);
                    if (product != null)
                    {
                        if (createTransactionDTO.Type == "entry")
                        {
                            product.Quantity += transactionDetail.Quantity * 2;
                        }
                        else
                        {
                            product.Quantity -= transactionDetail.Quantity * 2;
                        }
                        if(product.Quantity < 0) errors.Add($"{product.Name} não pode ser alterado");
                    }
                }
            }
            _mapper.Map(createTransactionDTO, transaction);
            _context.Entry(transaction).State = EntityState.Modified;
            if(errors.Count > 0) return BadRequest(errors);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException) when (!_context.Transactions.Any(e => e.Id == id))
            {
                return NotFound();
            }
            return NoContent();
        }
        return NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTransaction(int id)
    {
        var transaction = await _context.Transactions.FindAsync(id);
        if (transaction != null)
        {
            var transactionDetails = await _context.TransactionDetails.Where(td => td.TransactionId == id).ToListAsync();
            foreach (var transactionDetail in transactionDetails)
            {
                var product = await _context.Products.FindAsync(transactionDetail.ProductId);
                if (product != null)
                {
                    if (transaction.Type == "entry")
                    {
                        product.Quantity -= transactionDetail.Quantity;
                    }
                    else
                    {
                        product.Quantity += transactionDetail.Quantity;
                    }
                    _context.TransactionDetails.Remove(transactionDetail);
                }
            }
        }
        else
        {
            return NotFound();
        }

        _context.Transactions.Remove(transaction);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}