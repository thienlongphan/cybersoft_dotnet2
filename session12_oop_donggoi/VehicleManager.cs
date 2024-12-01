using Newtonsoft.Json;

namespace session12_oop_donggoi;

public class VehicleManager
{
    private List<Vehicle> vehicles;

    public List<Vehicle> Vehicles
    {
        get => vehicles;
        set
        {
            vehicles = value;
        }
    }

    private string filePath = "vehicles.json";
    
    // Viết hàm load data để đọc dữ liệu từ file json
    // => dùng thư viện Newtonsoft.json
    
    // constructor
    public VehicleManager()
    {
        LoadData();
    }

    private void LoadData() // dùng trong constructor
    {
        // Kiểm tra file có tồn tại không
        if (File.Exists(filePath))
        {
            // đọc dữ liệu từ file json
            string json = File.ReadAllText(filePath);
            
            // chuyển dữ liệu từ string json sang List<Vehicle>
            Vehicles = JsonConvert.DeserializeObject<List<Vehicle>>(json);
        }
        else
        {
            Vehicles = new List<Vehicle>();
        }
    }
    
    // Viet ham saveData để lưu dữ liệu vào file json
    private void SaveData() // Dùng trong hàm AddVehicle và RemoveVehicle
    {
        // Chuyển dữ liệu từ List<Vehicle> sang string json
        string json = JsonConvert.SerializeObject(Vehicles, Formatting.Indented);
        
        // lưu dữ liệu vào file json
        File.WriteAllText(filePath, json);
        Console.WriteLine($"Save successful: {filePath}");
    }
    
    // Viet ham AddVehicle để thêm phương tiện vào danh sách
    public void AddVehicle(Vehicle vehicle)
    {
        // Kiểm tra mã phương tiện đã tồn tại chưa
        Vehicle v = Vehicles.Find(item => item.VehicleId == vehicle.VehicleId);
        if (v != null)
        {
            throw new Exception("Vehicle already exists");
        }
        
        Vehicles.Add(vehicle);
        SaveData();
        Console.WriteLine($"Added vehicle {vehicle} successfully");
    }
    
    // Viet ham AddCar de them xe vao danh sach 
    public void AddCar()
    {
        Console.WriteLine("=== Adding car ===");
        Console.WriteLine("Enter vehicle number: ");
        string vehicleId = Console.ReadLine();
        
        Console.WriteLine($"Enter vehicle brand: ");
        string brand = Console.ReadLine();
        
        Console.WriteLine($"Enter vehicle yeah: ");
        int year = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"Enter vehicle model: ");
        string model = Console.ReadLine();
        
        Console.WriteLine($"Enter vehicle price: ");
        double price = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine($"Enter vehicle color: ");
        string color = Console.ReadLine();
        
        Console.WriteLine($"Enter vehicle engine: ");
        int engine = Convert.ToInt32(Console.ReadLine());

        Car car = new Car(vehicleId, brand, year, price, model, color, engine);
        AddVehicle(car);
    }
    
    // Viết hàm DisplayAllVehicle để hiện thị danh sách phương tiện
    public void DisplayAllVehicles()
    {
        Console.WriteLine("=== All vehicles ===");
        foreach (Vehicle vehicle in Vehicles)
        {
            vehicle.DisplayInfo();
            Console.WriteLine("----------------------");
        }
    }
}