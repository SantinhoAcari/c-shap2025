using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class TransactionDetailsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public TransactionDetailsController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TransactionDetailDTO>>> GetTransactionDetails()
    {
        var transactionDetails = await _context.TransactionDetails.ToListAsync();
        return _mapper.Map<List<TransactionDetailDTO>>(transactionDetails);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TransactionDetailDTO>> GetTransactionDetail(int id)
    {
        var transactionDetail = await _context.TransactionDetails.FindAsync(id);

        if (transactionDetail == null)
        {
            return NotFound();
        }

        return _mapper.Map<TransactionDetailDTO>(transactionDetail);
    }

    [HttpPost]
    public async Task<ActionResult<TransactionDetailDTO>> PostTransactionDetail(CreateTransactionDetailDTO createTransactionDetailDTO)
    {
        var errors = new List<string>();

        var product = await _context.Products.FindAsync(createTransactionDetailDTO.ProductId);
        var transaction = await _context.Transactions.FindAsync(createTransactionDetailDTO.TransactionId);

        if (product == null)
        {
            errors.Add("Product not found.");
        }

        if (transaction == null)
        {
            errors.Add("Transaction not found.");
        }

        if (errors.Any())
        {
            return NotFound(errors);
        }
        if (transaction != null && product != null)
        {
            if (transaction.Type == "entry")
            {
                product.Quantity += createTransactionDetailDTO.Quantity;
            }
            else if (transaction.Type == "exit")
            {
                if (product.Quantity < createTransactionDetailDTO.Quantity)
                {
                    return BadRequest($"Quantidade de produtos insuficiente. Restam {product.Quantity}");
                }
                product.Quantity -= createTransactionDetailDTO.Quantity;
            }
        }

        var transactionDetail = _mapper.Map<TransactionDetail>(createTransactionDetailDTO);

        _context.TransactionDetails.Add(transactionDetail);
        await _context.SaveChangesAsync();

        var transactionDetailDTO = _mapper.Map<TransactionDetailDTO>(transactionDetail);

        return CreatedAtAction(nameof(GetTransactionDetail), new { id = transactionDetailDTO.Id }, transactionDetailDTO);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutTransactionDetail(int id, CreateTransactionDetailDTO createTransactionDetailDTO)
    {
        if (id <= 0)
        {
            return BadRequest();
        }

        var transactionDetail = await _context.TransactionDetails.FindAsync(id);
        if (transactionDetail == null)
        {
            return NotFound();
        }

        _mapper.Map(createTransactionDetailDTO, transactionDetail);

        _context.Entry(transactionDetail).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException) when (!_context.TransactionDetails.Any(e => e.Id == id))
        {
            return NotFound();
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTransactionDetail(int id)
    {
        var transactionDetail = await _context.TransactionDetails.FindAsync(id);
        if (transactionDetail == null)
        {
            return NotFound();
        }

        _context.TransactionDetails.Remove(transactionDetail);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
