namespace ServiceProvider.Core.Interfaces.Services;

public class IActionContext
{
	Guid? ServiceProviderId { get; }
	
	Guid? ClientId { get; } 
	
	public Guid? ActiveUserId { get; }
	
	public string? ActiveUserName { get; }
	
	public Guid? LoggedInUserId { get; }
	
	public string? LoggedInUserName { get; }
}