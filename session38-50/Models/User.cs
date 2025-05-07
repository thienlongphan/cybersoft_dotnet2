using System.ComponentModel.DataAnnotations;

namespace session38_50.Models;

public class User
{
    [Key]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = String.Empty;
    
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email address")]
    public string Email { get; set; }
    
    public string Password { get; set; } = string.Empty; // Password đc mã hóa
    public bool IsEmailVerified {get; set; } = false;
    public string? VerificationToken { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string Role { get; set; } = "User";
    public string? TokenResetPassword { get; set; } = string.Empty;
    public DateTime? ExpiresTokenReset { get; set; }
}