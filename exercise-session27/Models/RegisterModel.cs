using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

public class RegisterModel
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

    [Required(ErrorMessage = "Please select a course")]
    public string Course { get; set; }

    [Required(ErrorMessage = "Please choose study mode")]
    public string StudyMode { get; set; }

    [Required(ErrorMessage = "Please select a start date")]
    public DateTime? StartDate { get; set; } = DateTime.Today;

    public string Comment { get; set; }

    [Range(typeof(bool), "true", "true", ErrorMessage = "You must agree to the terms and conditions.")]
    public bool Agree { get; set; } = false;
}

public class StudyMode 
{
    bool Online { get; set; }
    bool Offline { get; set; }
}