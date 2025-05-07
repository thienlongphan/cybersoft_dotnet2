using System.Net;
using Microsoft.Extensions.Options;
using session38_50.Models;
using StackExchange.Redis;

namespace session38_50.Middlewares;

public class RateLimitMiddleware : IMiddleware
{
    private readonly RateLimitSettings _settings;
    private readonly IConnectionMultiplexer _redis;

    public RateLimitMiddleware(IOptions<RateLimitSettings> settings, IConnectionMultiplexer redis)
    {
        _settings = settings.Value;
        _redis = redis;
    }
    
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        if (!_settings.Enabled)
        {
            await next(context);
            return;
        }
        
        var clientIp = context.Connection.RemoteIpAddress.ToString() ?? "Unknown";
        var db = _redis.GetDatabase();
        
        // Tao key cho API
        var key = $"ratelimit:ip:{clientIp}";
        // tang so luong request va lay gia tri moi
        var requestCount = await db.StringIncrementAsync(key);
        
        // net key dau tien set thoi gian het han
        if (requestCount == 1)
        {
            await db.KeyExpireAsync(key, TimeSpan.FromSeconds(_settings.Window));
        }

        if (requestCount > _settings.MaxRequests)
        {
            context.Response.StatusCode = (int)HttpStatusCode.TooManyRequests;
            context.Response.Headers["Retry-After"] = _settings.Window.ToString();
            await context.Response.WriteAsJsonAsync(new
            {
                error = "Too many requests",
                message = "Rate limit exceeded. Please try again later.",
                retryAfter = _settings.Window.ToString()
            });
            return;
        }
        await next(context);
    }
}