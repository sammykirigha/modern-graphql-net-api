using ServiceProvider.Core.Interfaces.Models;
using System.Text.Json.Serialization;

namespace ServiceProvider.Core.Models;

public class ServiceListingsServices : IEntity
{
	public Guid Id { get; set; }
	public Guid ServiceListingId { get; set; }
	public Guid ServiceId { get; set; }
	public DateTime DateCreated { get; set; }
	public DateTime DateModified { get; set; }
}