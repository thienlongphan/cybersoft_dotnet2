namespace session12_oop_donggoi;

public class Car : Vehicle
{
    private string model;

    public string Model
    {
        get => model;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Model cannot be null or empty");
            }
            model = value;
        }
    }

    private string color;

    public string Color
    {
        get => color;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Color cannot be null or empty");
            }
            color = value;
        }
    }

    private int engine;

    public int Engine
    {
        get => engine;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Engine cannot be less than 0");
            }
            engine = value;
        }
    }
    public Car(
        string vehicleId, 
        string brand, 
        int year, 
        double price, 
        string model, 
        string color, 
        int engine) : base(vehicleId, brand, year, price)
    {
        Model = model;
        Color = color;
        Engine = engine;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Color: {Color}");
    }
}