using Microsoft.EntityFrameworkCore;
using session38_50.Data;
using session38_50.Interfaces;
using session38_50.Models;

namespace session38_50.Repositories;

public class AuthRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public AuthRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<User> CreateUserAsync(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task<User?> GetUserByVerificationTokenAsync(string token)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.VerificationToken == token);
        if (user == null)
        {
            return null;
        }
        
        user.IsEmailVerified = true;
        user.VerificationToken = null;
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task<User?> GetUserByEmailAsync(string email)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
    }

    public async Task<User?> UpdateUserAsync(User user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task<User?> GetUserByResetTokenAsync(string token)
    {
        var user = await _context.Users.FirstOrDefaultAsync(u => u.TokenResetPassword == token);
        if (user == null)
        {
            return null;
        }
        
        // Kiem tra neu token het han
        if (DateTime.Now > user.ExpiresTokenReset)
        {
            return null;
        }
        
        return user;
    }

    public async Task SaveChangeAsync()
    {
        await _context.SaveChangesAsync();
    }
}