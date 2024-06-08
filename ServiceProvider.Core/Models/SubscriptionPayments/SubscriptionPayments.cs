using ServiceProvider.Core.Interfaces.Models;
using System.Text.Json.Serialization;
namespace ServiceProvider.Core.Models;

public partial class SubscriptionPayments : IEntity
{
    /// <summary>
    /// Primary key
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// foreign key Subscription
    /// </summary>
    public Guid SubscriptionId { get; set; }
    /// <summary>
    /// foreign key payment
    /// </summary>
    public Guid PaymentId { get; set; }
    /// <summary>
    /// StartDate
    /// </summary>
    public decimal? PaymentAmount  { get; set; }
    /// <summary>
    /// Date/time record created
    /// </summary>
    public DateTime DateModified { get; set; }
    /// <summary>
    /// Last date/time record changed
    /// </summary>
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    [JsonIgnore] public virtual Subscription? Subscription { get; set; }
    [JsonIgnore] public virtual Payment? Payment { get; set; }
}