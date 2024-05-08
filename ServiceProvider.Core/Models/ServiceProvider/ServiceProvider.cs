using ServiceProvider.Core.Interfaces.Models;

namespace ServiceProvider.Core.Models;

public partial class ServiceProvider: IEntity
{
	public Guid Id { get; set; }
	public string FirstName { get; set; } = string.Empty;
	public string LastName { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
	public string Phone { get; set; } = string.Empty;
	public Guid ServiceId { get; set; }
	public Guid LocationId { get; set; }
	public DateTime DateCreated { get; set; }
	public DateTime DateModified { get; set; }

	public virtual List<Service> Services { get; set; } = new List<Service>();
	public virtual Location? Location { get; set; }
}