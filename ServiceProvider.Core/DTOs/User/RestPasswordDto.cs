namespace ServiceProvider.Core.DTOs.User;

public class ResetPasswordInputDto
{
	public string Token { get; set; } = string.Empty;
	public string NewPassword { get; set; } = string.Empty;
	public string ConfirmPassword { get; set; } = string.Empty;
}

public class ResetPasswordResponseDto
{
	public bool Success { get; set; } = false;
	public string Message { get; set; } = string.Empty;
}