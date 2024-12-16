using exercise_session15._2;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        ProductManager manager = new ProductManager();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("==== Store Management System ====");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Display Product");
            Console.WriteLine("3. Calculate Total Price of Product");
            Console.WriteLine("4. Delete Product");
            Console.WriteLine("5. Exit");
            
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manager.AddProduct();
                    break;
                case 2:
                    manager.DisplayProducts();
                    break;
                case 3:
                    manager.calculatePrices();
                    break;
                case 4:
                    manager.DeleteProduct();
                    break;
                case 5:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Please try again (1-5).");
                    break;
            }
            
        }
    }
}
