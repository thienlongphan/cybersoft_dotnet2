namespace session13;

public class Fashion : Product
{
    private string size;

    public string Size
    {
        get => size;
        set
        {
            List<string> validSizes = new List<string> { "S", "M", "L", "XL", "XXL" };
            if (string.IsNullOrWhiteSpace(value) || !validSizes.Contains(value))
            {
                throw new ArgumentException($"'{value}' is not a valid size");
            }
            
            size = value;
        }
    }

    public Fashion(
        int productId, 
        string productName, 
        double price, 
        string description,
        string size) : base(productId, productName, price, description)
    {
        Size = size;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Size: {Size}");
    }

}