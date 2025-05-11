using authenticationService.Models;
using Microsoft.EntityFrameworkCore;

namespace authenticationService.Data;

public class AuthDbContext : DbContext
{
    public AuthDbContext(DbContextOptions<AuthDbContext> options) :base(options) {}
    public DbSet<User> Users { get; set; }
}