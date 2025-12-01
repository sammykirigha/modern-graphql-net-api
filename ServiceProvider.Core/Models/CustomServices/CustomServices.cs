using ServiceProvider.Core.Interfaces.Models;

namespace ServiceProvider.Core.Models;

public class CustomService: IEntity
{
	public Guid Id { get; set; }
	public Guid ServiceProviderId { get; set; }
	public string CustomServiceName { get; set; } = string.Empty;
	public DateTime DateCreated { get; set; }
	public DateTime DateModified { get; set; }
}