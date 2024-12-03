using exercise_session13;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        #region Bai 1

        StudentManager studentManager = new StudentManager();
        bool isRunningOne = true;
        
        while (isRunningOne)
        {
            Console.WriteLine("==== Student Management ====");
            Console.WriteLine("1. Add Info Student: ");
            Console.WriteLine("2. Find Info Student by Student Name: ");
            Console.WriteLine("3. Update Score Student: ");
            Console.WriteLine("4. Calculate Average Score Student and show results for student: ");
            Console.WriteLine("5. Delete Student of list by Student ID: ");
            Console.WriteLine("6. Show Student Info according by Average Score: ");
            Console.WriteLine("7. Show Student Info according by Average Score ascending: ");
            Console.WriteLine("8. Show Student Info according by Student Name Ascending: ");
            Console.WriteLine("9. Exit ");
            
            int choice = Convert.ToInt32(Console.ReadLine());
        
            switch (choice)
            {
                case 1:
                    studentManager.AddStudent();
                    break;
                case 2:
                    studentManager.SearchStudent();
                    break;
                case 3:
                    studentManager.UpdateScore();
                    break;
                case 4:
                    studentManager.CalculateAvarageScore();
                    break;
                case 5:
                    studentManager.DeleteStudent();
                    break;
                case 6:
                    studentManager.DisplayStudentInfo();
                    break;
                case 7:
                    studentManager.DisplayStudentInfo("avarageScore");
                    break;
                case 8:
                    studentManager.DisplayStudentInfo("studentName");
                    break;
                case 9:
                    isRunningOne = false;
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Please try again (1 -> 9).");
                    break;
            }
        }

        #endregion
        
        #region Bai 2
        
        ProductManager productManager = new ProductManager();
        OrderManager orderManager = new OrderManager();
        bool isRunning = true;
        
        while (isRunning)
        {
            Console.WriteLine("==== Product Management ====");
            Console.WriteLine("1. Add Info Product: ");
            Console.WriteLine("2. Find Info Product by Product Name: ");
            Console.WriteLine("3. Update Product Price and Inventory Quantity: ");
            Console.WriteLine("4. Calculate Total price of product: ");
            Console.WriteLine("5. Delete Product by Product Code: ");
            Console.WriteLine("6. Show Product Info with total price of product: ");
            Console.WriteLine("7. Show Product Info according by Product Price ascending: ");
            Console.WriteLine("8. Show Product Info according by Product Name Ascending: ");
            Console.WriteLine("9. Order Product: ");
            Console.WriteLine("10. Exit ");
            
            int choice = Convert.ToInt32(Console.ReadLine());
        
            switch (choice)
            {
                case 1:
                    productManager.AddProduct();
                    break;
                case 2:
                    productManager.SearchProductByName();
                    break;
                case 3:
                    productManager.UpdateProductPrice();
                    break;
                case 4:
                    productManager.CalculateTotalPriceOfItems();
                    break;
                case 5:
                    productManager.DeleteProduct();
                    break;
                case 6:
                    productManager.DisplayProductsWithTotalPrice();
                    break;
                case 7:
                    productManager.DisplayProductOrderByPrice();
                    break;
                case 8:
                    productManager.DisplayProductsWithProductName();
                    break;
                case 9:
                    orderManager.OrderProduct(productManager.Products);
                    break;
                case 10:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Please try again (1 -> 9).");
                    break;
            }
        }
        
        #endregion
    }
}