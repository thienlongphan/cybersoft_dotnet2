using System.ComponentModel.DataAnnotations;

namespace session38_50.Models.DTOs;

public class ResetPasswordDTO
{
    [Required(ErrorMessage = "Please enter reset password")]
    public string ResetToken { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Please enter new password")]
    public string NewPassword { get; set; } = string.Empty;
}