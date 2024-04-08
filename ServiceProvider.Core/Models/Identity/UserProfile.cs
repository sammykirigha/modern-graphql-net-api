namespace ServiceProvider.Core.Models;

public class UserProfile
{
	/// <summary>
	/// Id of user
	/// </summary>
	public Guid UserId { get; set; }

	/// <summary>
	/// First name of user
	/// </summary>
	public string FirstName { get; set; } = "";
	/// <summary>
	/// Last name of user
	/// </summary>
	public string LastName { get; set; } = "";
	/// <summary>
	/// Email of user
	/// </summary>
	public string Email { get; set; } = "";

	/// <summary>
	/// Id of user role
	/// </summary>
	public Guid? RoleId { get; set; }
	/// <summary>
	/// Id of active user (impersonated or not)
	/// </summary>
	public Guid? ActiveUserId { get; set; }
	/// <summary>
	/// First name of active user
	/// </summary>
	public string? ActiveUserFirstName { get; set; }
	/// <summary>
	/// Last name of active user
	/// </summary>
	public string? ActiveUserLastName { get; set; }
	/// <summary>
	///  Full name of user
	/// </summary>
	public string FullName
		=> $"{FirstName ?? ""} {LastName ?? ""}";

	/// <summary>
	///  Full name of acitve user
	/// </summary>
	public string ActiveUserFullName
		=> $"{ActiveUserFirstName ?? ""} {ActiveUserLastName ?? ""}";
}