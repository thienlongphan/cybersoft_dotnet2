using System.ComponentModel.DataAnnotations;

public class FeedbackModel 
{
    [Required(ErrorMessage = "Please enter first name")]
    public string FirstName {get; set;} = string.Empty;

    [Required(ErrorMessage = "Please enter last name")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Please enter email")]
    [EmailAddress(ErrorMessage = "Please enter valid email")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Please enter username")]
    public string UserName {get; set;}
    public int Cleaniness { get; set; } = 5;
    public int Staff { get; set; } = 5;
    public int Comfort { get; set; } = 5;
    public int Value { get; set; } = 5;
    public int FeedbackText { get; set; } = 5;
}