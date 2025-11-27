namespace ServiceProvider.Core.Interfaces.Passwords;

public interface IPasswordResetTokenService
{
	public string GenerateResetToken(string email);
	public string DecodeResetToken(string token);
}