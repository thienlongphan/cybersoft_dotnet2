namespace exercise_session15._2;

public class Food : Product
{
    public int ShippingFee { get; set; }
    
    public Food(string productCode, string productName, double originalPrice, int shippingFee) : base(productCode, productName, originalPrice)
    {
        ShippingFee = shippingFee;
    }
    
    public override double CalculateSellingPrice()
    {
        return OriginalPrice + ShippingFee;
    }
    
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        double sellingPrice = CalculateSellingPrice();
        Console.WriteLine($"Selling Price: {sellingPrice}");
    }
}