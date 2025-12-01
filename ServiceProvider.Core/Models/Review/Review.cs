using ServiceProvider.Core.Interfaces.Models;
using System.Text.Json.Serialization;

namespace ServiceProvider.Core.Models
{
    public class Review: IEntity
    { /// <summary>
    /// Primary key
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// ct of user (foreign key)
    /// </summary>
    public Guid? CustomerId { get; set; }
    /// <summary>
    /// sp of service (foreign key)
    /// </summary>
    public Guid? ServiceListingId { get; set; }
    /// <summary>
    /// Date/time record created
    /// </summary>
    public DateTime DateModified { get; set; }
    /// <summary>
    /// Last date/time record changed
    /// </summary>
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    /// <summary>
    /// Review comments
    /// </summary>
    public string Comments { get; set; } = "";
    /// <summary>
    /// Rating out of 5
    /// </summary>
    public int Rating { get; set; }
    [JsonIgnore] public virtual User? User { get; set; }
    [JsonIgnore] public virtual ServiceListing? ServiceListing { get; set; }

    [JsonIgnore] public virtual ICollection<ErrorLog> ErrorLogsActive { get; set; } = new List<ErrorLog>();
    [JsonIgnore] public virtual ICollection<ErrorLog> ErrorLogsLoggedIn { get; set; } = new List<ErrorLog>();
    [JsonIgnore] public virtual ICollection<EntityLog> EntityLogsActive { get; set; } = new List<EntityLog>();
    [JsonIgnore] public virtual ICollection<EntityLog> EntityLogsLoggedIn { get; set; } = new List<EntityLog>();
    
    [JsonIgnore] public virtual ICollection<LoginLog> LoginLogs { get; set; } = new List<LoginLog>();
    }
}