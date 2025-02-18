using System.Text.Json;

public class ProductService 
{
    private readonly HttpClient _httpClient;

    public ProductService(HttpClient httpClient) 
    {
        _httpClient = httpClient;
    }

    public async Task<List<Product>> GetProductsAsync() 
    {
        try 
        {
            var response = await _httpClient.GetStringAsync("Product");
            Console.WriteLine("API Response: " + response);

            var jsonDoc = JsonDocument.Parse(response);

            if(jsonDoc.RootElement.TryGetProperty("content", out JsonElement contentElement)) 
            {
                return JsonSerializer.Deserialize<List<Product>>(contentElement.GetRawText(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new List<Product>();
            } 
            else 
            {

            return new List<Product>();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return new List<Product>();
        }
    }
}