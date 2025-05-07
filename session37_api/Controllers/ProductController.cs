using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using session37_api.Models;
using session37_api.Data;

namespace session37_api.Controllers;

// Rule dat ten file controller
// Hau to la controller vd. ProductController
//[controller] => product
[ApiController] // Thong bao cho .NET biet controller minh tu tao
[Route("api/[controller]")] // api/product
public class ProductController : ControllerBase
{
    // define attribute cho doi tuong productController
    private readonly ApplicationDbContext _context;

    // define ham khoi tao
    public ProductController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    // define API
    // API GET PRODUCT
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetProducts(
        [FromQuery] string? name = null,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 10
        )
    {
        // Lấy header user agent
        var userAgent = Request.Headers["User-Agent"].ToString();
        // Log header
        Console.WriteLine($"User Agent: {userAgent}");
        
        var query = _context.Products.AsQueryable();
        if (!string.IsNullOrWhiteSpace(name))
        {
            query = query.Where(p => p.Name.Contains(name));
        }
        
        // phan trang
        var totalItems = await query.CountAsync();
        var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);
        var products = await query
            .Skip((page - 1) * pageSize)
            .Take(pageSize).ToListAsync();
        
        //return await _context.Products.ToListAsync();
        return Ok(new
        {
            Data = products, 
            Pagination = new
            {
                TotalItems = totalItems,
                TotalPages = totalPages,
                CurrentPage = page,
                PageSize = pageSize,
            }
        });
    }

    [HttpPost]
    public async Task<ActionResult<Product>> CreateProduct([FromBody] Product product)
    {
        // Kiem tra input
        if (!ModelState.IsValid)
        {
            return BadRequest(new
            {
                Message = "",
                Errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
            });
        }
        
        // kiem tra san pham
        var existingProduct = await _context.Products
                                    .FirstOrDefaultAsync(p => p.Name == product.Name);
        if (existingProduct != null)
        {
            return BadRequest( new
                {
                    Message = "Product already exists"
                });
        }
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return Ok( new
        {
            Message = "Product created",
            Data = product
        });
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetProductById(int id)
    {
        var product = await _context.Products.FindAsync(id);
        if (product == null)
        {
            return NotFound();
        }

        return Ok(new
        {
            Message = "Product found",
            Data = product
        });
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateProduct(int id, [FromBody] Product product)
    {
        if (id != product.Id)
        {
            return BadRequest( new 
            {
                Message = "Id mismatch"
            });
        }

        var existingProduct = await _context.Products.FindAsync(id);
        if (existingProduct == null)
        {
            return NotFound();
        }
        
        // Kiem tra input
        if (!ModelState.IsValid)
        {
            return BadRequest(new
            {
                Message = "Validation Failed",
                Errors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
            });
        }
        
        existingProduct.Name = product.Name;
        existingProduct.Price = product.Price;
        existingProduct.Description = product.Description;
        _context.Products.Update(existingProduct);
        await _context.SaveChangesAsync();
        return Ok(new
        {
            Message = "Product updated",
            Data = product
        });
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteProduct(int id)
    {
        var existingProduct = await _context.Products.FindAsync(id);
        if (existingProduct == null)
        {
            return NotFound();
        }
        
        _context.Products.Remove(existingProduct);
        await _context.SaveChangesAsync();
        return Ok();
    }
}