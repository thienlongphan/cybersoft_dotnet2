using System.ComponentModel.DataAnnotations;

public class FeedbackModel 
{
    [Required(ErrorMessage = "Please enter first name")]
    public string FirstName {get; set;} = string.Empty;
    public int Cleaniness { get; set; } = 5;
}