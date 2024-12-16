namespace session14;

public abstract class Room
{
    private string roomId;

    public string RoomId
    {
        get => roomId;
        set => roomId = value;
    }
    
    private string roomName;

    public string RoomName
    {
        get => roomName;
        set => roomName = value;
    }

    private double basePrice;
    public double BasePrice { get => basePrice; set => basePrice = value; }

    public Room(string roomId, string roomName ,double basePrice)
    {
        RoomId = roomId;
        BasePrice = basePrice;
        RoomName = roomName;
    }
    
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"RoomId: {RoomId}");
        Console.WriteLine($"RoomName: {RoomName}");
        Console.WriteLine($"Base Price: {BasePrice}");
    }

    public abstract double CalculatePrice();

    
}