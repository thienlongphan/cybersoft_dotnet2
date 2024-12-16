namespace session13;

public class Electronic : Product
{
    private int warranty;

    public int Warranty
    {
        get => warranty;
        set
        {
            if(value < 0) throw new ArgumentException("Warranty must be positive");
            warranty = value;
        }
    }

    public Electronic(
        int productId, 
        string productName, 
        double price, 
        string description, 
        int warranty) : base(productId, productName, price, description)
    {
        Warranty = warranty;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Warranty: {Warranty}");
    }
}