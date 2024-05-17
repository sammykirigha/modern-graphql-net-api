using ServiceProvider.Core.Interfaces.Models;
using System.Text.Json.Serialization;

namespace ServiceProvider.Core.Models;

public partial class Client: IEntity
{
	public Guid Id { get; set; }
	public string FirstName { get; set; } = string.Empty;
	public string LastName { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
	public string Phone { get; set; } = string.Empty;
	public Guid LocationId { get; set; }
	public DateTime DateCreated { get; set; }
	public DateTime DateModified { get; set; }
	public virtual Location? Location { get; set; }
	[JsonIgnore] public virtual ICollection<ClientsServices>? ClientServices { get; set; } = new List<ClientsServices>();
}