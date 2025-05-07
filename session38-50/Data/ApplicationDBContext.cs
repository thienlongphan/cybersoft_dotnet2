namespace session38_50.Data;
using Microsoft.EntityFrameworkCore;
using session38_50.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    // Add cac model entity
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
}