using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using session38_50.Interfaces;
using session38_50.Models.DTOs;

namespace session38_50.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProductResponseDTO>>> GetProducts()
    {
        var products = await _productService.GetAllProductsAsync();
        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ProductResponseDTO>> GetProduct(int id)
    {
        var product = await _productService.GetProductAsync(id);
        if (product == null)
        {
            return NotFound();
        }
        return Ok(product);
    }

    [Authorize]
    [HttpPost]
    public async Task<ActionResult<ProductResponseDTO>> CreateProduct(ProductRequestDTO productRequest)
    {
        // validate model
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        
        // Kiem tra role cua User
        // User nay la property cua priciple
        var userRole = User.FindFirst(ClaimTypes.Role)?.Value;
        if (userRole != "Admin")
        {
            return Unauthorized(new { message = "You are not authorized to access this resource." });
        }
        
        var createdProduct = await _productService.CreateProductAsync(productRequest);
        return Ok(createdProduct);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ProductResponseDTO?>> UpdateProduct(int id, ProductRequestDTO productRequestDTO)
    {
        var updatedProduct = await _productService.UpdateProductAsync(id, productRequestDTO);
        if (updatedProduct == null)
        {
            return NotFound();
        }
        return Ok(updatedProduct);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteProduct(int id)
    {
        var isDeleted = await _productService.DeleteProductAsync(id);
        if (isDeleted)
        {
            return NoContent();
        }
        return NotFound();
    }
}