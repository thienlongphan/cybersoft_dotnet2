namespace exercise_session13;

public class Product
{
    private string productCode;

    public string ProductCode
    {
        get => productCode;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Product Code cannot be empty");
            } 
            productCode = value;
        }
    }

    private string productName;

    public string ProductName
    {
        get => productName;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Product Name cannot be empty");
            }
            productName = value;
        }
    }
    
    private int productPrice;

    public int ProductPrice
    {
        get => productPrice;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Product Price cannot be negative");
            }
            
            productPrice = value;
        }
    }

    private int inventoryQuantity;

    public int InventoryQuantity
    {
        get => inventoryQuantity;

        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Inventory Quantity cannot be negative");
            }
            
            inventoryQuantity = value;
        }
    }

    public Product(string productCode, string productName, int productPrice, int inventoryQuantity)
    {
        ProductCode = productCode;
        ProductName = productName;
        ProductPrice = productPrice;
        InventoryQuantity = inventoryQuantity;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("====== Product Information ======");
        Console.WriteLine($"Product Code: {ProductCode}");
        Console.WriteLine($"Product Name: {ProductName}");
        Console.WriteLine($"Product Price: {ProductPrice}");
        Console.WriteLine($"Inventory Quantity: {InventoryQuantity}");
    }

    public int CalculateTotalPrice()
    {
        return ProductPrice * InventoryQuantity;
    }
}