using Newtonsoft.Json;

namespace exercise_session15._2;

public class ProductManager
{
    private string _pathFile = "products.json";
    
    public List<Product> ListProducts { get; set; }

    public ProductManager()
    {
        ReadFromFile();
    }
    
    private void ReadFromFile()
    {
        if (File.Exists(_pathFile))
        {
            string json = File.ReadAllText(_pathFile);
            ListProducts = JsonConvert.DeserializeObject<List<Product>>(json, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            })!;
            Console.WriteLine("Load data successfully");
        }
        else
        {
            ListProducts = new List<Product>();
        }
    }
    
    
    private void WriteToFile()
    {
        string json = JsonConvert.SerializeObject(ListProducts, new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented
        });
        File.WriteAllText(_pathFile, json);
        Console.WriteLine($"Saved data to {_pathFile} successfully");
    }

    public void AddProduct()
    {
        Console.WriteLine("choose type of product: ");
        Console.WriteLine("1. Electronic");
        Console.WriteLine("2. Fashion");
        Console.WriteLine("3. Food");
        int typeProduct = Convert.ToInt32(Console.ReadLine());
        switch (typeProduct)
        {
            case 1:
                (string electronicCode, string electronicName, double electronicPrice) = InputProdutInfo();
                Console.WriteLine($"Enter Warranty tax (%): ");
                double tax = Convert.ToInt32(Console.ReadLine());
                Product electronic = new Electronic(electronicCode, electronicName, electronicPrice, tax);
                ListProducts.Add(electronic);
                break;
            case 2:
                (string fashionCode, string fashionName, double fashionPrice) = InputProdutInfo();
                Console.WriteLine($"Enter discount (%): ");
                double discount = Convert.ToDouble(Console.ReadLine());
                Product fashion = new Fashion(fashionCode, fashionName, fashionPrice, discount);
                ListProducts.Add(fashion);
                break;
            case 3:
                (string foodCode, string foodName, double foodPrice) = InputProdutInfo();
                Console.WriteLine($"Enter Shipping Fee: ");
                int fee = Convert.ToInt32(Console.ReadLine());
                Product food = new Food(foodCode, foodName, foodPrice, fee);
                ListProducts.Add(food);
                break;
            default:
                Console.WriteLine("Enter a valid choice, please try again (1-3): ");
                return;
                
        }
        WriteToFile();
        Console.WriteLine("Add product successfully");
    }

    private (string, string, double) InputProdutInfo()
    {
        Console.WriteLine("Enter product code: ");
        string productCode = Console.ReadLine();
        Console.WriteLine("Enter product name: ");
        string productName = Console.ReadLine();
        Console.WriteLine("Enter product price: ");
        double productPrice = Convert.ToDouble(Console.ReadLine());
        return (productCode, productName, productPrice);
    }

    public void DisplayProducts()
    {
        Console.WriteLine("List of products:");

        foreach (Product product in ListProducts)
        {
            Console.WriteLine("==== Product Info ====");
            product.DisplayInfo();
        }
    }

    public void calculatePrices()
    {
        Console.WriteLine("Calculating prices:");
        double price = 0;

        foreach (Product product in ListProducts)
        {
            price += product.CalculateSellingPrice();
        }
        
        Console.WriteLine($"Total price is {price}");
    }

    public void DeleteProduct()
    {
        Console.WriteLine("Enter your product code to delete: ");
        string productCode = Console.ReadLine();
        
        Product? product = ListProducts.FirstOrDefault(item => item.ProductCode == productCode);

        if (product != null)
        {
            ListProducts.Remove(product);
            Console.WriteLine("Delete product successfully");
        }
        else
        {
            Console.WriteLine("Product not found");
        }
    }
}