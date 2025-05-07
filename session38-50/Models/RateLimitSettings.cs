namespace session38_50.Models;

public class RateLimitSettings
{
    public bool Enabled { get; set; }
    public int Window { get; set; }
    public int MaxRequests { get; set; }
}