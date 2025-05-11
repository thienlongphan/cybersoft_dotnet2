using authenticationService.Data;
using authenticationService.DTOs;
using authenticationService.Models;
using Microsoft.EntityFrameworkCore;

namespace authenticationService.Services;

public class AuthService
{
    private readonly AuthDbContext _context;
    private readonly IConfiguration _configuration;
    private readonly IHttpClientFactory _httpClientFactory;

    public AuthService(
        AuthDbContext context, 
        IConfiguration configuration, 
        IHttpClientFactory httpClientFactory)
    {
        _context = context;
        _configuration = configuration;
        _httpClientFactory = httpClientFactory;
    }

    public async Task<AuthResponseDTO> Register(RegisterDTO registerDTO)
    {
        if (await _context.Users.AnyAsync(u => u.Email == registerDTO.Email))
        {
            throw new Exception($"Email {registerDTO.Email} already exists");
        }

        var user = new User
        {
            Username = registerDTO.Username,
            Email = registerDTO.Email,
            PasswordHash = registerDTO.Password
        };
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        // Send email welcome -> call API Email Service
        var client = _httpClientFactory.CreateClient("EmailService");
        await client.PostAsJsonAsync("api/email/welcome", new
        {
            email = registerDTO.Email,
            username = registerDTO.Username,
        });
        
        return new AuthResponseDTO
        {
            Token = "test",
            Username = user.Username,
        };
    }
}