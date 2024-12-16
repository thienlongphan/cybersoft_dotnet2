namespace exercise_session15._2;

public class Fashion : Product
{
    public double Discount { get; set; }

    public Fashion(string productCode, string productName, double originalPrice, double discount) : base(productCode, productName, originalPrice)
    {
        Discount = discount;
    }
    
    public override double CalculateSellingPrice()
    {
        return OriginalPrice - OriginalPrice * (Discount / 100);
    }
    
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        double sellingPrice = CalculateSellingPrice();
        Console.WriteLine($"Selling Price: {sellingPrice}");
    }
}