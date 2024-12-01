namespace session12_oop_donggoi;

public class Vehicle
{
    private string vehicleId;

    public string VehicleId
    {
        get => vehicleId;
        set => vehicleId = value;
    }

    private string brand;

    public string Brand
    {
        get => brand;
        set => brand = value;
    }

    private int year;

    public int Year
    {
        get => year;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Year cannot be negative");
            }
            year = value;
        }
    }

    private double price;

    public double Price
    {
        get => price;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price cannot be negative");
            }
            price = value;
        }
    }
    
    // Constructor
    public Vehicle(string vehicleId, string brand, int year, double price)
    {
        VehicleId = vehicleId;
        Brand = brand;
        Year = year;
        Price = price;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Vehicle Id: {VehicleId}");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Price: {Price}");
    }
}