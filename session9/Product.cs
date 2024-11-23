namespace session9;

public class Product
{
    public int productCode;
    public string productName;
    public int productPrice;
    public int inventoryQuantity;

    public void InputProduct()
    {
        Console.WriteLine("Enter product code:");
        productCode = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter product name:");
        productName = Console.ReadLine();
        
        Console.WriteLine("Enter product price:");
        productPrice = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter inventory quantity:");
        inventoryQuantity = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"Product code: {productCode}");
        Console.WriteLine($"Product name: {productName}");
        Console.WriteLine($"Product price: {productPrice}");
        Console.WriteLine($"Inventory quantity: {inventoryQuantity}");
    }
}