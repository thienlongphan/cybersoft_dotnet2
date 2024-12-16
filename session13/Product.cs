namespace session13;

public class Product
{
    private int productId;

    public int ProductId
    {
        get => productId;
        set
        {
            if(value < 0) throw new ArgumentException("Product id cannot be less than 0");
            productId = value;
        }
    }
    
    // 5 error exception
    // 1. lỗi logic và tham số (ArgumentException...)
    // 2. Lỗi dữ liệu (FormatException)
    // 3. Lỗi hệ thống
    // 4. Lỗi I/O và mạng
    // 5. Lỗi Thread

    private string productName;

    public string ProductName
    {
        get => productName;
        set
        {
            if(string.IsNullOrEmpty(value)) throw new ArgumentException("Product name cannot be empty");
            productName = value;
        }
    }
    
    private double price;

    public double Price
    {
        get => price;
        set
        {
            if(value < 0) throw new ArgumentException("Price cannot be less than 0");
            price = value;
        }
    }

    private string description;

    public string Description
    {
        get => description;
        set
        {
            if(string.IsNullOrEmpty(value)) throw new ArgumentException("Product description cannot be empty");
            description = value;
        }
    }

    public Product(int productId, string productName, double price, string description)
    {
        ProductId = productId;
        ProductName = productName;
        Price = price;
        Description = description;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Product ID: {ProductId}");
        Console.WriteLine($"Product Name: {ProductName}");
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"Description: {Description}");
    }
}