using ServiceProvider.Core.Interfaces.Models;

namespace ServiceProvider.Core.Models;

public class ProviderServices: IEntity
{
	public Guid Id { get; set; }
	public Guid ServiceProviderId { get; set; }
	public Guid ServiceId { get; set; }
	public DateTime DateCreated { get; set; }
	public DateTime DateModified { get; set; }
}