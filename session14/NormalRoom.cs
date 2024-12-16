namespace session14;

public class NormalRoom : Room, IWifi
{
    public NormalRoom(string roomId, string roomName, double basePrice) : base(roomId, roomName, basePrice)
    {
        
    }

    public override double CalculatePrice()
    {
        return BasePrice;
    }

    public bool HasWifi()
    {
        return true;
    }
}