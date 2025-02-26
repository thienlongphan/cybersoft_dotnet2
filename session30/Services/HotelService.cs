using System.Net.Http.Json;

public class HotelService {
    private readonly HttpClient _httpClient;

    public HotelService(HttpClient httpClient) 
    {
        _httpClient = httpClient;
    }

    public async Task<List<HotelModel>> GetHotelByCityAsync(string city) 
    {
        var response = await _httpClient.GetFromJsonAsync<HotelsData>("hotels.json");
        return response?.HotelsByCity.ContainsKey(city) == true 
               ? response.HotelsByCity[city] 
               : new List<HotelModel>();
    }
}