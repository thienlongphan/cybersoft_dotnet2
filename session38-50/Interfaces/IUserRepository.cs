using session38_50.Models;

namespace session38_50.Interfaces;

public interface IUserRepository
{
    Task<User> CreateUserAsync(User user);
    Task<User?> GetUserByVerificationTokenAsync(string token);
    Task<User?> GetUserByEmailAsync(string email);
    Task<User?> UpdateUserAsync(User user);
    Task<User?> GetUserByResetTokenAsync(string token);
    Task SaveChangeAsync();
}