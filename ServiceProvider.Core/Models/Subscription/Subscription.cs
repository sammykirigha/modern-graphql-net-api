using ServiceProvider.Core.Enums;
using ServiceProvider.Core.Interfaces.Models;
using System.Text.Json.Serialization;
namespace ServiceProvider.Core.Models;


public partial class Subscription : IEntity
{
        /// <summary>
    /// Primary key
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// foreign key
    /// </summary>
    public Guid PlanId { get; set; }
    /// <summary>
    /// foreign key
    /// </summary>
    public Guid ServiceProviderId { get; set; }
    /// <summary>
    /// StartDate
    /// </summary>
    public DateTime StartDate { get; set; } = DateTime.UtcNow;
    /// <summary>
    /// Status
    /// </summary>
    public SubscriptionStatus Status { get; set; }
    /// StartDate
    /// </summary>
    public DateTime EndDate { get; set; } = DateTime.UtcNow;
    /// <summary>
    /// RenewalType
    /// </summary>
    public RenewalType RenewalType { get; set; }
    /// <summary>
    /// Date/time record created
    /// </summary>
    public DateTime DateModified { get; set; }
    /// <summary>
    /// Last date/time record changed
    /// </summary>
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    [JsonIgnore] public virtual ServiceProviderEntity? ServiceProvider { get; set; }
    [JsonIgnore] public virtual Plan? Plan { get; set; }
}