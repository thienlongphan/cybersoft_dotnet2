using Newtonsoft.Json;

namespace exercise_session13;

public class ProductManager
{
    private string pathName = "products.json";
    
    public List<Product> Products { get; set; }

    public ProductManager()
    {
        LoadData();
    }
    
    private void LoadData()
    {
        if (File.Exists(pathName))
        {
            Products = JsonConvert.DeserializeObject<List<Product>>(File.ReadAllText(pathName));
            Console.WriteLine("Load data successful");
        }
        else
        {
            Products = new List<Product>();
            Console.WriteLine("Data does not exist, creating a new instance");
        }
    }
    
    private void SaveData()
    {
        File.WriteAllText(pathName, JsonConvert.SerializeObject(Products, Formatting.Indented));
        Console.WriteLine("Save Data Successful");
    }

    public void AddProduct()
    {
        Console.WriteLine("====== Adding Product =======");
        Console.WriteLine("Enter Product Code: ");
        string productCode = Console.ReadLine();
        
        Console.WriteLine("Enter Product Name: ");
        string productName = Console.ReadLine();
        
        Console.WriteLine("Enter Product price: ");
        int productPrice = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter Inventory Quantity: ");
        int inventoryQuantity = Convert.ToInt32(Console.ReadLine());
        
        Product product = new Product(productCode, productName, productPrice, inventoryQuantity);
        
        if (Products.Any(item => item.ProductCode == product.ProductCode))
        {
            throw new Exception("Product already exists");
        }
        else
        {
            Products.Add(product);
            SaveData();
            Console.WriteLine("Add Product Successful");
        }
    }

    public void SearchProductByName()
    {
        Console.WriteLine("====== Searching Product =======");
        Console.WriteLine("Enter Product Name: ");
        string productName = Console.ReadLine();
        
        if (string.IsNullOrEmpty(productName))
        {
            throw new Exception("Product name is empty");
        }
        
        Product product = Products.FirstOrDefault(item => item.ProductName == productName);
        
        if (product == null)
        {
            throw new Exception("Product not found");
        }
        
        product.DisplayInfo();
    }


    public void UpdateProductPrice()
    {
        Console.WriteLine("====== Updating Product Price =======");
        Product product = FindProduct();
        
        Console.WriteLine("Enter Product price: ");
        int productPrice = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter Inventory Quantity: ");
        int inventoryQuantity = Convert.ToInt32(Console.ReadLine());
        
        product.ProductPrice = productPrice;
        product.InventoryQuantity = inventoryQuantity;
        SaveData();
        Console.WriteLine("==== Update Product price Successful ====");
        product.DisplayInfo();
    }

    public void CalculateTotalPriceOfItems()
    {
        Console.WriteLine("====== Calculating Total Price Of Item =======");
        Product product = FindProduct();
        Console.WriteLine($"Product Name: {product.ProductName}, Total Price: {product.CalculateTotalPrice()}");
    }


    public void DeleteProduct()
    {
        Console.WriteLine("====== Deleting Product =======");
        Product product = FindProduct();
        
        Products.Remove(product);
        SaveData();
        Console.WriteLine($"==== Delete Product {product.ProductName} Successful ======");
    }

    public void DisplayProductsWithTotalPrice()
    {
        Console.WriteLine("====== Displaying Product with TotalPrice =======");

        foreach (Product product in Products)
        {
            product.DisplayInfo();
            Console.WriteLine($"Product total price: {product.CalculateTotalPrice()}");
            Console.WriteLine("=======================================================");
        }
    }

    public void DisplayProductOrderByPrice()
    {
        Console.WriteLine("====== Displaying Product orderby Price ========");
        List<Product> products = Products.OrderBy(product => product.ProductPrice).ToList();

        foreach (Product product in products)
        {
            product.DisplayInfo();
            Console.WriteLine("=======================================================");
        }
    }

    public void DisplayProductsWithProductName()
    {
        Console.WriteLine("====== Displaying Product with name ========");
        List<Product> products = Products.OrderBy(product => product.ProductName).ToList();
        foreach (Product product in products)
        {
            product.DisplayInfo();
            Console.WriteLine("=======================================================");
        }
    }
    
    
    private Product FindProduct()
    {
        Console.WriteLine("Enter Product Code: ");
        string productCode = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(productCode))
        {
            throw new Exception("Product Code is empty");
        }
        
        Product product = Products.FirstOrDefault(item => item.ProductCode == productCode);
        
        if(product == null) throw new Exception("Product not found");
        return product;
    }
}