using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public ProductsController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProducts()
    {
        var products = await _context.Products.ToListAsync();
        return _mapper.Map<List<ProductDTO>>(products);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProductDTO>> GetProduct(int id)
    {
        var product = await _context.Products.FindAsync(id);

        if (product == null)
        {
            return NotFound();
        }

        return _mapper.Map<ProductDTO>(product);
    }

    [HttpPost]
    public async Task<ActionResult<ProductDTO>> PostProduct(CreateProductDTO createProductDTO)
    {
        var categoryExists = await _context.Categories.AnyAsync(c => c.Id == createProductDTO.CategoryId);
        if (!categoryExists) return NotFound("A categoria especificada não foi encontrada.");
        var product = _mapper.Map<Product>(createProductDTO);

        _context.Products.Add(product);
        await _context.SaveChangesAsync();

        var productDTO = _mapper.Map<ProductDTO>(product);

        return CreatedAtAction(nameof(GetProduct), new { id = productDTO.Id }, productDTO);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutProduct(int id, CreateProductDTO createProductDTO)
    {
        if (id <= 0)
        {
            return BadRequest();
        }

        var categoryExists = await _context.Categories.AnyAsync(c => c.Id == createProductDTO.CategoryId);
        if (!categoryExists) return NotFound("A categoria especificada não foi encontrada.");

        var product = await _context.Products.FindAsync(id);
        if (product == null)
        {
            return NotFound();
        }

        _mapper.Map(createProductDTO, product);

        _context.Entry(product).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException) when (!_context.Products.Any(e => e.Id == id))
        {
            return NotFound();
        }
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        var transactionDetailsToDelete = await _context.TransactionDetails.AnyAsync(t => t.ProductId == id);
        if(transactionDetailsToDelete) return BadRequest("Este produto não pode ser excluído porque está sendo usado em alguma transação");
        var product = await _context.Products.FindAsync(id);
        if (product == null)
        {
            return NotFound();
        }

        _context.Products.Remove(product);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
