using System.ComponentModel.DataAnnotations;

public class Contact 
{
    [Required(ErrorMessage = "Full name is required")]
    [MinLength(3, ErrorMessage = "Full name must be at least 3 characters long")]
    public string FullName { get; set; }

    [Required(ErrorMessage = "Email is required")]
    [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Email is not valid")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Phone number is required")]
    [MinLength(10, ErrorMessage = "Phone number must be 10-12 digits")]
    [MaxLength(12, ErrorMessage = "Phone number must be 10-12 digits")]
    public string PhoneNumber { get; set; }

    [MinLength(5, ErrorMessage = "Address must be at least 5 characters long")]
    public string Address { get; set; }

    [Required(ErrorMessage = "Message is required")]
    [MinLength(10, ErrorMessage = "Message must be at least 10 characters long")]
    public string Message { get; set; }

    [Required(ErrorMessage = "Service is required")]
    public string Service { get; set; }

    [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree to the terms and conditions.")]
    public bool Agree { get; set; } = false;
}