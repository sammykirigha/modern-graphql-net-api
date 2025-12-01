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
	public Guid ServiceId { get; set; }		
	/// <summary>
	/// foreign key
	/// </summary>
	public Guid ServiceProviderId { get; set; }	
	/// <summary>
	/// foreign key
	/// </summary>
	public Guid? CustomServiceId { get; set; }
	/// <summary>
	/// Date/time record created
	/// </summary>
	public PaymentModes PaymentMode { get; set; } 
	public DateTime DateModified { get; set; }
	/// <summary>
	/// Last date/time record changed
	/// </summary>
	public DateTime DateCreated { get; set; } = DateTime.UtcNow;
	[JsonIgnore] public virtual ICollection<Review>? Reviews { get; set; } = new List<Review>();
	[JsonIgnore] public virtual ICollection<Booking>? Bookings { get; set; } =  new List<Booking>();
	[JsonIgnore] public virtual ServiceProviderEntity? ServiceProvider { get; set; }
	[JsonIgnore] public virtual Service? Service { get; set; }
	[JsonIgnore] public virtual CustomService? CustomService { get; set; }
}