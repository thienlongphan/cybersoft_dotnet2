using exercise_session15._1;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        
        ThanhToanManager manager = new ThanhToanManager();
        
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Chao mung den voi he thong thanh toan!");
            Console.WriteLine("1. Thanh toan bang tien mat");
            Console.WriteLine("2. Thanh toan bang the");
            Console.WriteLine("3. Thanh toan online");
            Console.WriteLine("4. Xem lich su giao dich");
            Console.WriteLine("5. Thoat");
            Console.WriteLine("Vui long chon chuc nang: ");
            
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manager.ThanhToanBangTienMatMethod();
                    break;
                case 2:
                    manager.ThanhToanTheMethod();
                    break;
                case 3:
                    manager.ThanhToanOnlineMethod();
                    break;
                case 4:
                    manager.DisplayHistoryTransactions();
                    break;
                case 5:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le vui long chon lai");
                    break;
            }
        }
    }
}
