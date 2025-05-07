using Microsoft.EntityFrameworkCore;
using session38_50.Data;
using session38_50.Interfaces;
using session38_50.Models;

namespace session38_50.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;
    
    public ProductRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        return await _context.Products.ToListAsync();
    }

    public async Task<Product?> GetProductByIdAsync(int id)
    {
        return await _context.Products.FindAsync(id);
    }

    public async Task<Product> CreateProductAsync(Product product)
    {
        product.CreatedAt = DateTime.UtcNow;
        product.UpdatedAt = DateTime.UtcNow;
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
        return product;
    }

    public async Task<Product?> UpdateProductAsync(int id, Product product)
    {
        var productToUpdate = await _context.Products.FindAsync(id);
        if (productToUpdate == null)
        {
            return null;
        }
        productToUpdate.CategoryID = product.CategoryID;
        productToUpdate.Description = product.Description;
        productToUpdate.Name = product.Name;
        productToUpdate.Price = product.Price;
        productToUpdate.Stock = product.Stock;
        productToUpdate.Discount = product.Discount;
        productToUpdate.OriginalPrice = product.OriginalPrice;
        productToUpdate.UpdatedAt = DateTime.UtcNow;
        _context.Products.Update(productToUpdate);
        await _context.SaveChangesAsync();
        return productToUpdate;
    }

    public async Task<bool> DeleteProductAsync(int id)
    {
        var productToDelete = await _context.Products.FindAsync(id);
        if (productToDelete == null)
        {
            return false;
        }
        
        _context.Products.Remove(productToDelete);
        await _context.SaveChangesAsync();
        return true;
    }
}