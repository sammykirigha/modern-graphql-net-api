namespace ServiceProvider.Core.Interfaces.EmailService;
public interface IEmailService
{
	Task SendEmailAsync(string toEmail, string subject, string body);
}
