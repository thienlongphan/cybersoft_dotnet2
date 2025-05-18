namespace emailService.Services;

public interface IEmailService
{
    Task SendWelcomeEmailAsync(string email, string username);
}