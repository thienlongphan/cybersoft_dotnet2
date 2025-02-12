using System.ComponentModel.DataAnnotations;

public class ContactModel 
{
    [Required(ErrorMessage = "Full name is required")]
    [MinLength(3, ErrorMessage = "Full name must be at least 3 characters name")]
    public string FullName {get; set;}

    [Required(ErrorMessage = "Email is required")]
    [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "Email invalid")]
    public string Email {get; set;}

    [Required(ErrorMessage = "Phone number is required")]
    [RegularExpression(@"^\d{10,12}$", ErrorMessage = "Phone number must be number")]
    public string PhoneNumber { get;set; } = string.Empty;

    public string Address { get;set; } = string.Empty;

    [Required(ErrorMessage = "Message is required")]
    [MinLength(0, ErrorMessage = "Message must be at least 10 characters name")]
    public string Message { get;set; } = string.Empty;

    [Required(ErrorMessage = "Please select a service")]
    public string Service { get;set; } = string.Empty;

    [Required(ErrorMessage = "You must agree before submitting")]
    public bool AgreeCondition { get;set; } = false;
}