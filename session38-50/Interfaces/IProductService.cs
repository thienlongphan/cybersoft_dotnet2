using session38_50.Models.DTOs;

namespace session38_50.Interfaces;

public interface IProductService
{
    Task<IEnumerable<ProductResponseDTO>> GetAllProductsAsync();
    Task<ProductResponseDTO?> GetProductAsync(int id);
    Task<ProductResponseDTO> CreateProductAsync(ProductRequestDTO productRequestDTO);
    Task<ProductResponseDTO?> UpdateProductAsync(int id, ProductRequestDTO productRequestDTO);
    Task<bool> DeleteProductAsync(int id);
}