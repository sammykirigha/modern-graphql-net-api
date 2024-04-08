
namespace ServiceProvider.Core;

public struct ClaimType
{
	public static ClaimType UserId { get; set; } = new ClaimType("uid");
	public static ClaimType FirstName { get; set; } = new ClaimType("fname");
	public static ClaimType LastName { get; set; } = new ClaimType("lname");
	public static ClaimType Email { get; set; } = new ClaimType("email");
	public static ClaimType RoleId { get; set; } = new ClaimType("roleid");
    
	public static ClaimType ActiveUserId { get; set; } = new ClaimType("actuid");
	public static ClaimType ActiveUserFullName { get; set; } = new ClaimType("actname");


	// implementation
	private readonly string Value;

	private ClaimType(string value) => Value = value;

	public override readonly string ToString() => Value;

	public static implicit operator string(ClaimType x) => x.Value;
}

