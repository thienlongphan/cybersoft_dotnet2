namespace session12_oop_donggoi;

public class Motocycle : Vehicle
{
    private string type;

    public string Type
    {
        get => type;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException($"Type '{value}' cannot be null or empty.");
            } 
            type = value;
        }
    }

    private int power;

    public int Power
    {
        get => power;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException($"Power '{value}' cannot be negative.");
            }
            power = value;
        }
    }

    public Motocycle(
        string vehicleId, 
        string brand, 
        int year, 
        double price, 
        string type, 
        int power) : base(vehicleId,
        brand, year, price)
    {
        Type = type;
        Power = power;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine($"Power: {Power}");
        
    }
}