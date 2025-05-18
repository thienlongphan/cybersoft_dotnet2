using System.Text.Json;
using Confluent.Kafka;

namespace emailService.Services;

public class KafkaConsumerService: BackgroundService
{
    private readonly IConsumer<string, string> _consumer;
    private readonly IEmailService _emailService;
    private const string Topic = "user-registered";

    public KafkaConsumerService(IEmailService emailService)
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:9092",
            GroupId = "email-service-group",
            AutoOffsetReset = AutoOffsetReset.Earliest,
        };
        _consumer = new ConsumerBuilder<string, string>(config).Build();
        _emailService = emailService;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        // subscribe topic
        _consumer.Subscribe(Topic);

        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                var consumeResult =  _consumer.Consume(stoppingToken);
                // convert json to object
                var message = JsonSerializer.Deserialize<UserRegistered>(consumeResult.Message.Value);
                if (message != null)
                {
                    await _emailService.SendWelcomeEmailAsync(message.Email, message.Username);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}

public class UserRegistered
{
    public required string Email { get; set; }
    public required string Username { get; set; }
    public DateTime Timestamp { get; set; }
}