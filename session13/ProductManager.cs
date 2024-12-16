using Newtonsoft.Json;

namespace session13;

public class ProductManager
{
    private List<Product> products;
    private string filePath = "product.json";

    private void LoadData()
    {
        if (!File.Exists(filePath))
        {
            products = new List<Product>();
        }
        else
        {
            string json = File.ReadAllText(filePath);
            products = JsonConvert.DeserializeObject<List<Product>>(json);
        }
    }

    public ProductManager()
    {
        LoadData();
    }

    private void SaveData()
    {
        string json = JsonConvert.SerializeObject(products, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
        SaveData();
    }

    public void AddElectronic()
    {
        Console.WriteLine("Enter Product ID: ");
        int productID = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Product Name: ");
        string productName = Console.ReadLine();
        Console.WriteLine("Enter Product Price: ");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Product Description: ");
        string productDescription = Console.ReadLine();
        Console.WriteLine("Enter Product Warranty: ");
        int warranty = Convert.ToInt32(Console.ReadLine());

        Electronic electronic = new Electronic(productID, productName, price, productDescription, warranty);
        
        AddProduct(electronic);
    }

    public void DisplayAllProducts()
    {
        // sắp xếp giảm dần theo giá
        products.Sort((p1, p2) => p2.Price.CompareTo(p1.Price));
        foreach (Product product in products)
        {
            product.DisplayInfo();
            Console.WriteLine("==========================");
        }
        
        // c2 OrderBy ko ảnh hưởng tới List ban đầu
        List<Product> sortedProducts = products.OrderBy(p => p.Price).ToList();
        foreach (Product product in sortedProducts)
        {
            product.DisplayInfo();
            Console.WriteLine("=========================");
        }
    }

    public void SearchByName(string name)
    {
        Product product = products.Find(item => item.ProductName.ToLower() == name.ToLower());
        if (product == null)
        {
            Console.WriteLine("Product not found");
        }
        else
        {
            product.DisplayInfo();
        }
    }
    
}