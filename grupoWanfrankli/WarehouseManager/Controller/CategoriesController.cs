using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;


    public CategoriesController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CategoryDTO>>> GetCategories()
    {
        var categories = await _context.Categories.ToListAsync();
        return _mapper.Map<List<CategoryDTO>>(categories);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CategoryDTO>> GetCategory(int id)
    {
        // var category = await _context.Categories.FindAsync(id);
        var productsToDelete = await _context.Products.Where(p => p.CategoryId == id).ToListAsync();
        return Ok(productsToDelete);
        // if (category == null)
        // {
        //     return NotFound();
        // }

        // return _mapper.Map<CategoryDTO>(category);
    }

    [HttpPost]
    public async Task<ActionResult<CategoryDTO>> PostCategory(CreateCategoryDTO createCategoryDTO)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var category = _mapper.Map<Category>(createCategoryDTO);

        _context.Categories.Add(category);
        await _context.SaveChangesAsync();

        var categoryDTO = _mapper.Map<CategoryDTO>(category);

        return CreatedAtAction(nameof(GetCategory), new { id = categoryDTO.Id }, categoryDTO);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> PutCategory(int id, CreateCategoryDTO createCategoryDTO)
    {
        if (id <= 0)
        {
            return BadRequest();
        }

        var category = await _context.Categories.FindAsync(id);
        if (category == null)
        {
            return NotFound();
        }

        _mapper.Map(createCategoryDTO, category);

        _context.Entry(category).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException) when (!_context.Categories.Any(e => e.Id == id))
        {
            return NotFound();
        }
        var categoryDTO = _mapper.Map<CategoryDTO>(category);
        return Ok(categoryDTO);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteCategory(int id)
    {
        var productsToDelete = await _context.Products.AnyAsync(p => p.CategoryId == id);

        if (productsToDelete)
            return BadRequest("Esta categoria não pode ser excluída porque está sendo usada em algum produto.");

        var category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);

        if (category == null)
            return NotFound();

        _context.Categories.Remove(category);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}
