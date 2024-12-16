namespace exercise_session15._2;

public class Electronic : Product
{
    public double Tax { get; set; }

    public Electronic(string productCode, string productName, double originalPrice, double tax) : base( productCode, productName, originalPrice)
    {
        Tax = tax;
    }
    
    
    public override double CalculateSellingPrice()
    {
        return OriginalPrice + OriginalPrice * (Tax / 100);
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        double sellingPrice = CalculateSellingPrice();
        Console.WriteLine($"Selling Price: {sellingPrice}");
    }
}