namespace ServiceProvider.Core.DTOs.User;
public class ForgetPasswordInputDto
{
	public string Email { get; set; } = string.Empty;
}

public class ForgetPasswordResponseDto
{
	public string Message { get; set; } = string.Empty;
}