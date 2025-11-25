using ServiceProvider.Core.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ServiceProvider.Core.Models
{
    public class Review: IEntity
    {
          /// <summary>
    /// Primary key
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Id of booking (foreign key)
    /// </summary>
    public Guid? BookingId { get; set; }
    /// <summary>
    /// Id of user (foreign key)
    /// </summary>
    public Guid? CustomerId { get; set; }
    /// <summary>
    /// Id of service (foreign key)
    /// </summary>
    public Guid? ServiceId { get; set; }
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
    /// <summary>
    /// Is verifiedTransactionId approved
    /// </summary>
    public string verifiedTransactionId { get; set; } = "";
    /// <summary>
    /// Is review active
    /// </summary>
    public TransactionType TransactionType { get; set; }
    [JsonIgnore] public virtual Booking? Booking { get; set; }
    [JsonIgnore] public virtual User? User { get; set; }
    [JsonIgnore] public virtual Service? Service { get; set; }

    [JsonIgnore] public virtual ICollection<ErrorLog> ErrorLogsActive { get; set; } = new List<ErrorLog>();
    [JsonIgnore] public virtual ICollection<ErrorLog> ErrorLogsLoggedIn { get; set; } = new List<ErrorLog>();
    [JsonIgnore] public virtual ICollection<EntityLog> EntityLogsActive { get; set; } = new List<EntityLog>();
    [JsonIgnore] public virtual ICollection<EntityLog> EntityLogsLoggedIn { get; set; } = new List<EntityLog>();
    
    [JsonIgnore] public virtual ICollection<LoginLog> LoginLogs { get; set; } = new List<LoginLog>();
    }
}