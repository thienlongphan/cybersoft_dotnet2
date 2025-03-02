using System.ComponentModel.DataAnnotations;

public class HistoryModel 
{
    public string ActionState { get; set; } = string.Empty;
    public double Amount { get; set; } = 0.00;
    public DateTime DateAction { get; set; } = DateTime.Today;
}

public class WalletDialogModel 
{
    [Range(1, double.MaxValue, ErrorMessage = "Must be greater than 0")]
    public double Amount {get; set;}
}