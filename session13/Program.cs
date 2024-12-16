using session13;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        
        // Bài tập về quản lý sản phẩm cửa hàng
        // class:
        // - product
        // + productID: int
        // + productName: string
        // + price: double
        // + description: string
        
        // - Electronics
        // + warranty: int
        
        // - productManager
        // + List<Product> products
        // + filePath: string
        
        ProductManager productManager = new ProductManager();
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("\n=== Product Manager ===");
            Console.WriteLine("1. Add Electronic Product: ");
            Console.WriteLine("2. Add Fashion Product: ");
            Console.WriteLine("3. Display All Products: ");
            Console.WriteLine("4. Search Product");
            Console.WriteLine("5. Exit.");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    productManager.AddElectronic();
                    break;
                case 2:
                    Console.WriteLine("Add Fashion Product: ");
                    break;
                case 3:
                    productManager.DisplayAllProducts();
                    break;
                case 4:
                    Console.WriteLine("Enter Product name: ");
                    string productName = Console.ReadLine();
                    productManager.SearchByName(productName);
                    break;
                case 5:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}