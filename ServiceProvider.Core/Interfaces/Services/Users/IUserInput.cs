namespace ServiceProvider.Core.Interfaces.Services.Users;

public interface IUserInput
{
	string Email { get; set; }
	string FirstName { get; set; }
	string LastName { get; set; }
	string Password { get; set; }
}