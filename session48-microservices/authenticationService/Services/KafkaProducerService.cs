using System.Text.Json;
using Confluent.Kafka;

namespace authenticationService.Services;

public class KafkaProducerService
{
    private readonly IProducer<string, string> _producer;
    private const string Topic = "user-registered";

    public KafkaProducerService()
    {
        var config = new ProducerConfig
        {
            BootstrapServers = "kafka-container:9092",
        };
        _producer = new ProducerBuilder<string, string>(config).Build();
    }
    
    // Viet ham de send event toi mesessage broker
    public async Task PublishUserRegisteredEvent(string email, string username)
    {
        // define new message 
        var message = new
        {
            Email = email,
            Username = username,
            Timestamp = DateTime.UtcNow
        };
        
        // Convert ve dang JSON
        var jsonMessage = JsonSerializer.Serialize(message);

        await _producer.ProduceAsync(Topic, new Message<string, string>
        {
            Key = email,
            Value = jsonMessage
        });
    }
    
    // Viet ham de close producer, clear bo nho
    public void Dispose()
    {
        _producer.Dispose();
    }
}