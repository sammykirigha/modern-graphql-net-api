using ServiceProvider.Core.Interfaces.Models;
using System.Text.Json.Serialization;

namespace ServiceProvider.Core.Models;

public partial class ClientsServices : IEntity
{
    /// <summary>
    /// Primary key
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Id of service (foreign key)
    /// </summary>
    public Guid ServiceId { get; set; }
    /// <summary>
    /// Id of location (foreign key)
    /// </summary>
    public Guid ClientId { get; set; }
    /// <summary>
    /// Date/time record created
    /// </summary>
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    /// <summary>
    /// Last date/time record changed
    /// </summary>
    public DateTime DateModified { get; set; } = DateTime.UtcNow;
    [JsonIgnore] public virtual Service? Service { get; set; }
    [JsonIgnore] public virtual Client? Client { get; set; }
}