namespace session14;

public class SuitRoom : Room, IWifi
{
    private string extraService;
    public string ExtraService { get => extraService; set => extraService = value; }

    private string premiumService;
    public string PremiumService { get => premiumService; set => premiumService = value; }
    
    public SuitRoom(string roomId, string roomName, double basePrice, string extraService, string premiumService) : base(roomId, roomName, basePrice)
    {
        ExtraService = extraService;
        PremiumService = premiumService;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Extra Service: {ExtraService}");
        Console.WriteLine($"Premium Service: {PremiumService}");
    }

    public override double CalculatePrice()
    {
        return BasePrice + 200;
    }

    public bool HasWifi()
    {
        return true;
    }
}