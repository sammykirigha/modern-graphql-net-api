using ServiceProvider.Core.Settings;
using ServiceProvider.Core.Interfaces.EmailService;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;

namespace ServiceProvider.Services.Services.EmailService;
public class SmtpEmailService : IEmailService
{
	private readonly EmailSettings _emailSettings;
	public SmtpEmailService(IOptions<EmailSettings> emailSettings)
	{
		_emailSettings = emailSettings.Value;
	}

	public async Task SendEmailAsync(string toEmail, string subject, string body)
	{
		var message = new MimeMessage();
		message.From.Add(new MailboxAddress(_emailSettings.SenderName, _emailSettings.SenderEmail));
		message.To.Add(MailboxAddress.Parse(toEmail));
		message.Subject = subject;
		message.Body = new TextPart("html") { Text = body };

		using var client = new SmtpClient();
		try
		{
			await client.ConnectAsync(_emailSettings.SmtpHost, _emailSettings.SmtpPort,
				SecureSocketOptions.StartTls);
			await client.AuthenticateAsync(_emailSettings.SmtpUserName, _emailSettings.SmtpPassword);
			await client.SendAsync(message);
			await client.DisconnectAsync(true);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex);
			throw new InvalidOperationException("Failed to send email", ex);
		}
	}
}