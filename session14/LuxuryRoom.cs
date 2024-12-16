namespace session14;

public class LuxuryRoom : Room, IWifi
{
    private string extraService;
    public string ExtraService { get => extraService; set => extraService = value; }

    public LuxuryRoom(string roomId, string roomName, double basePrice, string extraService) : base(roomId, roomName, basePrice)
    {
        ExtraService = extraService;
    }

    public override double CalculatePrice()
    {
        return BasePrice + 100;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Extra Service: {ExtraService}");
    }

    public bool HasWifi()
    {
        return true;
    }
}