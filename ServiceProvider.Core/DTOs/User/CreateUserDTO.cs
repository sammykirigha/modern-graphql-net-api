
namespace ServiceProvider.Core.DTOs.User;
public partial class CreateUserDTO
{
    /// <summary>
	/// First name of user
	/// </summary>
	public string FirstName { get; set; } = "";
    /// <summary>
    /// Last name of user
    /// </summary>
    public string LastName { get; set; } = "";
    /// <summary>
    /// Primary email of user
    /// </summary>
    public string Email { get; set; } = "";
    /// <summary>
    /// Primary Password of user
    /// </summary>
    public string Password { get; set; } = "";
    /// <summary>
    /// Primary phone number of user
    /// </summary>
    public string? Phone { get; set; }
    /// <summary>
    /// Date/time record created
    /// </summary>
}