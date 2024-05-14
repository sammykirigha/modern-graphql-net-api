using System.Collections;
using System.Text.Json.Serialization;
using ServiceProvider.Core.Interfaces.Models;
 
namespace ServiceProvider.Core.Models;
public partial class Service : IEntity
{
    /// <summary>
    /// Primary key
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Name of role
    /// </summary>
    public string Name { get; set; } = "";
    /// <summary>
    /// price per service
    /// </summary>
    public decimal Price { get; set; }
    /// <summary>
    /// foreign key
    /// </summary>
    public Guid CategoryId { get; set; }
    /// <summary>
    /// foreign key
    /// </summary>
    public Guid LocationId { get; set; }
     /// <summary>
    /// foreign key
    /// </summary>
    public Guid ClientId { get; set; }
    /// <summary>
    /// foreign key ServiceProviderClient id
    /// </summary>
    public Guid? ServiceProviderClientId { get; set; }
    /// <summary>
    /// Date/time record created
    /// </summary>
    public DateTime DateModified { get; set; }

    /// <summary>
    /// Last date/time record changed
    /// </summary>
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
 
    [JsonIgnore] public virtual Category? Category { get; set; }
    [JsonIgnore] public virtual ICollection<ServiceLocation>? ServiceLocations { get; set; } = new List<ServiceLocation>();
    [JsonIgnore] public virtual ICollection<ClientService>? ClientServices { get; set; } = new List<ClientService>();
}