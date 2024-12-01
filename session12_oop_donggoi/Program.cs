using session12_oop_donggoi;

internal class Program {
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        

        #region Lý thuyết đóng gói
        // Tính đóng gói trong OOP (Encapsulation)
        // giới hạn phạm vi truy cập các thuộc tính trong class
        // nhằm bảo vệ dữ liệu của class
        // => các thuộc tính của class nên được khai báo là private
        // truy cập các private thông qua getter và setter
        
        // Tạo đối tượng Person
        // Dùng try...catch để bắt lỗi nếu có lỗi xảy ra
        try
        {
            Person person = new Person("Long", 18);
            // person.name = "John";  lỗi vì private
            person.Name = "John";
            Console.WriteLine(person.Name);
            
            Console.WriteLine("=====");
            Person person1 = new Person("Nguyen Van B", -1);
            
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        

        #endregion

        #region Bài tập 1

        // 1. Tạo class cha Vehicle
        // - vehicleId: mã phương tiện
        // - brand: hãng xe
        // - year: năm sản xuất
        // - price: giá xe
        // 1.1 Tạo class Car kế thừa từ Vehicle
        // - model: dòng xe
        // - color: màu xe
        // - engine: dung tích động cơ
        // 1.2 Tạo class Motor kế thừa từ Vehicle
        // - type: loại xe (số tay, số tự động)
        // - power: công suất
        // Tạo class VehicleManager để quản lý phương tiện giao thông
        // - danh sách phương tiện
        // - file json lưu thông tin phương tiện (nâng cao)
        // 3. Yêu cầu chức năng
        // - Thêm phương tiện vào danh sách
        // * check xem mã phương tiện đã tồn tại chưa. Nếu có rồi thì báo lỗi.
        // lưu phương tiện mới vào file json (sử dụng thư viện Newtonsoft.Json)
        // - Hiển thị danh sách phương tiện
        // - Tìm phương tiện theo mã phương tiện
        // - Thoát

        #endregion
        
        // Tạo đối tượng VehicleManager
        VehicleManager vehicleManager = new VehicleManager();
        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine($"1. Thêm phương tiện xe hơi");
            Console.WriteLine($"2. Hiển thị danh sách phương tiện");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice (1 - 3): ");
            
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: 
                    vehicleManager.AddCar();
                    break;
                case 2:
                    vehicleManager.DisplayAllVehicles();
                    break;
                case 3:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Out of my choice");
                    break;
            }
        }
        
    }
}
