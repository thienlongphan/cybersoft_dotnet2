using session38_50.Interfaces;
using session38_50.Models;
using session38_50.Models.DTOs;

namespace session38_50.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    
    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<IEnumerable<ProductResponseDTO>> GetAllProductsAsync()
    {
        var products = await _productRepository.GetAllProductsAsync();
        return products.Select(p => MapToProductResponseDto(p));
    }

    public async Task<ProductResponseDTO?> GetProductAsync(int id)
    {
        var product = await _productRepository.GetProductByIdAsync(id);
        if (product == null)
        {
            return null;
        }
        return MapToProductResponseDto(product);
    }

    public async Task<ProductResponseDTO> CreateProductAsync(ProductRequestDTO productRequest)
    {
        // Tạo entity từ ProductRequestDTO
        var product = new Product
        {
            Name = productRequest.Name,
            Description = productRequest.Description,
            Price = productRequest.Price,
            Stock = productRequest.Stock,
            Discount = productRequest.Discount,
            OriginalPrice = productRequest.OriginalPrice,
            Sold = 0,
            Rating = 0,
            ReviewCount = 0,
            Thumbnail = ""
        };
        // Gui entity vao repository
        var productCreated = await _productRepository.CreateProductAsync(product);
        // return DTO
        return MapToProductResponseDto(productCreated);
    }
    
    public async Task<ProductResponseDTO?> UpdateProductAsync(int id, ProductRequestDTO productRequest)
    {
        var product = new Product
        {
            Name = productRequest.Name,
            Description = productRequest.Description,
            Price = productRequest.Price,
            Stock = productRequest.Stock,
            Discount = productRequest.Discount,
            OriginalPrice = productRequest.OriginalPrice,
            Sold = 0,
            Rating = 0,
            ReviewCount = 0,
            Thumbnail = ""
        };
        var result = await _productRepository.UpdateProductAsync(id, product);
        if (result == null)
        {
            return null;
        }
        return MapToProductResponseDto(result);
    }

    public async Task<bool> DeleteProductAsync(int id)
    {
        return await _productRepository.DeleteProductAsync(id);
    }

    private ProductResponseDTO MapToProductResponseDto(Product product)
    {
        return new ProductResponseDTO
        {
            ProductID = product.ProductID,
            CategoryID = product.CategoryID,
            Description = product.Description,
            Name = product.Name,
            Price = product.Price,
            OriginalPrice = product.OriginalPrice,
            Discount = product.Discount,
            Thumbnail = product.Thumbnail,
            Stock = product.Stock,
            Sold = product.Sold,
            Rating = product.Rating,
            ReviewCount = product.ReviewCount,
        };
    }
}