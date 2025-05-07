
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using session38_50.Interfaces;

namespace session38_50.Services;

public class EmailService : IEmailService
{
    private readonly IConfiguration _configuration;

    public EmailService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task SendEmailAsync(string to, string subject, string body)
    {
        // b1: khoi tao email mime
        var email = new MimeMessage();
        
        // b2: setup thong tin nguoi gui
        email.From.Add(MailboxAddress.Parse(_configuration["EmailSettings:From"]));
        
        // b3: setup info nguoi nhan
        email.To.Add(MailboxAddress.Parse(to));
        
        // b4: Setup thong tin chu de (subject)
        email.Subject = subject;
        
        // b5: setup noi dung email (Body)
        var builder = new BodyBuilder
        {
            HtmlBody = body
        };
        
        email.Body = builder.ToMessageBody();
        
        // b6: thiet lap SMTP client
        var smtpClient = new SmtpClient();
        await smtpClient.ConnectAsync(_configuration["EmailSettings:SmtpServer"], int.Parse(_configuration["EmailSettings:Port"]), SecureSocketOptions.StartTls);
        await smtpClient.AuthenticateAsync(_configuration["EmailSettings:Username"], _configuration["EmailSettings:Password"]);
        
        // b7. gui email
        await smtpClient.SendAsync(email);
        await smtpClient.DisconnectAsync(true);
    }
}