using ServiceProvider.Core.Enums;
using ServiceProvider.Core.Interfaces.Models;
using System.Text.Json.Serialization;

namespace ServiceProvider.Core.Models;
public partial class ServiceListing:IEntity
{
	/// <summary>
	/// Primary key
	/// </summary>
	public Guid Id { get; set; }
	/// <summary>
	/// Name of role
	/// </summary>
	public double? BasePrice { get; set; } = 0.00;
	/// <summary>
	/// foreign key
	/// </summary>
	public Guid ServiceProviderId { get; set; }	
	/// <summary>
	/// Date/time record created
	/// </summary>
	public PaymentModes PaymentMode { get; set; } 
	public DateTime DateModified { get; set; }
	public string BusinessName { get; set; } = string.Empty;
	public string BusinessDescription { get; set; } = string.Empty;
	/// <summary>
	/// Last date/time record changed
	/// </summary>
	public DateTime DateCreated { get; set; } = DateTime.UtcNow;
	[JsonIgnore] public virtual ICollection<Review>? Reviews { get; set; } = new List<Review>();
	[JsonIgnore] public virtual ICollection<Booking>? Bookings { get; set; } =  new List<Booking>();
	[JsonIgnore] public virtual ICollection<ServiceListingsServices>? ServiceListingsServices { get; set; } =  new List<ServiceListingsServices>();
	[JsonIgnore] public virtual ServiceProviderEntity? ServiceProvider { get; set; }
}