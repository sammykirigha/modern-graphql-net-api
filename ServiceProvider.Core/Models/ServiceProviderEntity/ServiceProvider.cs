using ServiceProvider.Core.Interfaces.Models;
using System.Text.Json.Serialization;

namespace ServiceProvider.Core.Models;

public partial class ServiceProviderEntity: IEntity
{
	public Guid Id { get; set; }
	public string FirstName { get; set; } = string.Empty;
	public string LastName { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
	public string Phone { get; set; } = string.Empty;
	public string BusinessName { get; set; } = string.Empty;
	public string BusinessDescription { get; set; } = string.Empty;
	public  Guid UserId { get; set; }
	public bool IsActive { get; set; }
	public DateTime DateCreated { get; set; }
	public DateTime DateModified { get; set; }
	[JsonIgnore] public virtual ICollection<Service>? Services { get; set; } = new List<Service>();
	[JsonIgnore] public virtual ICollection<Booking>? Bookings { get; set; } = new List<Booking>();
	[JsonIgnore] public virtual ICollection<ServiceListing>? ServiceListings { get; set; } = new List<ServiceListing>();

	[JsonIgnore] public virtual Subscription? Subscription { get; set; }
}