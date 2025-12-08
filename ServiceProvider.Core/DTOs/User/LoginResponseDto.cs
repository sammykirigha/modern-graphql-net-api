using Azure.Core;

namespace ServiceProvider.Core.DTOs.User;

public class LoginResponseDto
{
	public string AccessToken { get; set; } = string.Empty;
	public string RefreshToken { get; set; } = string.Empty;
}