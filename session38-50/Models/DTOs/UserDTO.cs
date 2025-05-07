namespace session38_50.Models.DTOs;

public class UserDTO
{
    public string Name { get; set; } = String.Empty;
    public string Email { get; set; }
    public string Password { get; set; } = string.Empty; // Password đc mã hóa
    public string Role { get; set; } = "User";
}