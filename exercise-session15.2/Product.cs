namespace exercise_session15._2;

public abstract class Product
{
    public string ProductCode { get; set; }
    public string ProductName { get; set; }
    public double OriginalPrice { get; set; }
    
    public abstract double CalculateSellingPrice();

    public Product(string productCode, string productName, double originalPrice)
    {
        ProductCode = productCode;
        ProductName = productName;
        OriginalPrice = originalPrice;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Product Code: {0}", ProductCode);
        Console.WriteLine("Product Name: {0}", ProductName);
        Console.WriteLine("Original Price: {0}", OriginalPrice);
    }
}