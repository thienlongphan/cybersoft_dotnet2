using session38_50.Models;
using session38_50.Models.DTOs;

namespace session38_50.Interfaces;

public interface IUserService
{
    Task<UserDTO> CreateUserAsync(UserDTO user);
    Task<UserDTO?> VerifyEmailAsync(string token);
    Task<string?> LoginAsync(LoginDTO loginDto);
    Task<User?> GetUserByEmailAsync(string email);
    Task<User?> ForgotPasswordAsync(string email);
    Task<User?> ResetPasswordAsync(ResetPasswordDTO resetPasswordDto);
}