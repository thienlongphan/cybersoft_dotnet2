using System.ComponentModel.DataAnnotations;

namespace session38_50.Models.DTOs;

public class ForgotPassDTO
{
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Invalid Email Address")]
    public string Email { get; set; }
}