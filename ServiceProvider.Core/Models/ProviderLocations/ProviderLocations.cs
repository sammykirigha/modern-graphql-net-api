using ServiceProvider.Core.Interfaces.Models;

namespace ServiceProvider.Core.Models;

public class ProviderLocations: IEntity
{
	public Guid Id { get; set; }
	public Guid ServiceProviderId { get; set; }
	public Guid LocationId { get; set; }
	public DateTime DateCreated { get; set; }
	public DateTime DateModified { get; set; }
}