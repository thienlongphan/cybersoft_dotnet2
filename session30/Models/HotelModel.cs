public class HotelModel 
{
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string Link { get; set; }
    public int Rating { get; set; }
    public string Description { get; set; }
}

public class HotelsData 
{
    public Dictionary<string, List<HotelModel>> HotelsByCity { get; set; }
}