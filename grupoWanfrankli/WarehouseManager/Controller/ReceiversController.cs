using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class ReceiversController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public ReceiversController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ReceiverDTO>>> GetReceivers()
    {
        var receivers = await _context.Receivers.ToListAsync();
        return _mapper.Map<List<ReceiverDTO>>(receivers);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ReceiverDTO>> GetReceiver(int id)
    {
        var receiver = await _context.Receivers.FindAsync(id);

        if (receiver == null)
        {
            return NotFound();
        }

        return _mapper.Map<ReceiverDTO>(receiver);
    }

    [HttpPost]
    public async Task<ActionResult<ReceiverDTO>> PostReceiver(CreateReceiverDTO createReceiverDTO)
    {
        var receiver = _mapper.Map<Receiver>(createReceiverDTO);

        _context.Receivers.Add(receiver);
        await _context.SaveChangesAsync();

        var receiverDTO = _mapper.Map<ReceiverDTO>(receiver);

        return CreatedAtAction(nameof(GetReceiver), new { id = receiverDTO.Id }, receiverDTO);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutReceiver(int id, CreateReceiverDTO createReceiverDTO)
    {
        if (id <= 0)
        {
            return BadRequest();
        }

        var receiver = await _context.Receivers.FindAsync(id);
        if (receiver == null)
        {
            return NotFound();
        }

        _mapper.Map(createReceiverDTO, receiver);

        _context.Entry(receiver).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException) when (!_context.Receivers.Any(e => e.Id == id))
        {
            return NotFound();
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteReceiver(int id)
    {
        var transactionsToDelete = await _context.Transactions.AnyAsync(p => p.ReceiverId == id);
        if (transactionsToDelete) return BadRequest("Este recebedor não pode ser excluído porque está sendo usada em alguma transação");

        var receiver = await _context.Receivers.FindAsync(id);
        if (receiver == null)
        {
            return NotFound();
        }

        _context.Receivers.Remove(receiver);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
