using System.IdentityModel.Tokens.Jwt;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using session38_50.Interfaces;
using session38_50.Models;
using session38_50.Models.DTOs;

namespace session38_50.Services;

public class AuthService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IEmailService _emailService;
    private readonly IConfiguration _configuration;

    public AuthService(
        IUserRepository userRepository, 
        IEmailService emailService, 
        IConfiguration configuration)
    {
        _userRepository = userRepository;
        _emailService = emailService;
        _configuration = configuration;
    }

    public async Task<UserDTO> CreateUserAsync(UserDTO userDTO)
    {
        //Ma hoa password
        userDTO.Password = BCrypt.Net.BCrypt.HashPassword(userDTO.Password);
        
        // Tạo token để verify new account
        var token = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
        
        // Tạo link Verify new account
        // Link nay la API de verify account
        var baseUrl = _configuration["AppSettings:BaseUrl"];
        var verifyUrl = $"{baseUrl}/verify-email?token={Uri.EscapeDataString(token)}";
        
        // new user
        var user = new User
        {
            Email = userDTO.Email,
            Name = userDTO.Name,
            Password = userDTO.Password,
            VerificationToken = token,
            IsEmailVerified = false,
            Role = userDTO.Role
        };
        // create new user
        await _userRepository.CreateUserAsync(user);
        
        // send email to new user 
        var emailBody = $@"
            <h1>Welcome to our website!</h1>
            <p>You have successfully registered to our website</p>
            <p>Your user name {user.Email}</p>
            <a href='{verifyUrl}'>Verify your Email</a>
        ";
        
        await _emailService.SendEmailAsync(user.Email, "Test" ,emailBody);
        return userDTO;
    }

    public async Task<UserDTO?> VerifyEmailAsync(string token)
    {
        var user = await _userRepository.GetUserByVerificationTokenAsync(token);
        if (user == null)
        {
            return null;
        }
        
        var userDto = new UserDTO
        {
            Email = user.Email, 
            Name = user.Name, 
            Password = user.Password
        };
        return userDto;
    }
    
    // define function generate JWT Token
    private string GenerateJWTToken(User user)
    {
        var security = _configuration["JWT:Key"];
        var formatKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(security));
        var credentials = new SigningCredentials(formatKey, SecurityAlgorithms.HmacSha256);
        
        // Tao claims (Luu nhung info co ban cua user de BE verify)
        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
            new Claim(JwtRegisteredClaimNames.Email, user.Email),
            new Claim(ClaimTypes.Role, user.Role),
        };
        
        // Tao Token 
        var token = new JwtSecurityToken(
            issuer: _configuration["JWT:Issuer"], 
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(60),
            signingCredentials: credentials,
            audience: _configuration["JWT:Audience"]
            );
        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    public async Task<string?> LoginAsync(LoginDTO loginDto)
    {
        var user = await _userRepository.GetUserByEmailAsync(loginDto.Email);
        if (user == null)
        {
            return null;
        }
        // verify password
        var isCorrectPassword = BCrypt.Net.BCrypt.Verify(loginDto.Password, user.Password);
        if (!isCorrectPassword)
        {
            return null;
        }

        if (!user.IsEmailVerified)
        {
            return null;
        }

        string token = GenerateJWTToken(user);
        return token;
    }
    
    public async Task<User?> GetUserByEmailAsync(string email) {
        var user = await _userRepository.GetUserByEmailAsync(email);
        return user;
    }
    
    public async Task<User?> ForgotPasswordAsync(string email) {
        var user = await GetUserByEmailAsync(email);
        if(user == null) {
            return null;
        }

        var tokenResetPassword = GenerateResetPassword();
        // lưu thông tin token reset vao database
        user.TokenResetPassword = tokenResetPassword;
        user.ExpiresTokenReset = DateTime.UtcNow.AddHours(60);
        var userUpdated = await _userRepository.UpdateUserAsync(user);
        
        // Gui email den email 
        await _emailService.SendEmailAsync(user.Email, "Reset Password", $"Your token is: {tokenResetPassword}");
        return userUpdated;
    }

    public async Task<User?> ResetPasswordAsync(ResetPasswordDTO resetPasswordDto)
    {
        var user = await _userRepository.GetUserByResetTokenAsync(resetPasswordDto.ResetToken);

        if (user == null)
        {
            return null;
        }
        
        // ma hoa password moi
        user.Password = BCrypt.Net.BCrypt.HashPassword(resetPasswordDto.NewPassword);
        user.TokenResetPassword = null;
        user.ExpiresTokenReset = null;
        
        await _userRepository.UpdateUserAsync(user);
        return user;
    }

    private string GenerateResetPassword()
    {
        return Convert.ToBase64String(Guid.NewGuid().ToByteArray());
    }
}