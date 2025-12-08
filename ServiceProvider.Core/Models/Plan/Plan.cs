using ServiceProvider.Core.Enums;
using ServiceProvider.Core.Interfaces.Models;
using System.Text.Json.Serialization;

namespace ServiceProvider.Core.Models;

public partial class Plan : IEntity
{
    /// <summary>
    /// Primary key
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Name of plan eg Free, Pro, Enterprise
    /// </summary>
    public string Name { get; set; } = "";
    /// <summary>
    /// Name of plan eg Description
    /// </summary>
    public string Description { get; set; } = "";
    /// <summary>
    /// BillingCycle To define the billing cycle for the plan (e.g., monthly, yearly)
    /// </summary>
    public BillingCycle BillingCycle { get; set; }
    /// <summary>
    /// To indicate whether the plan is currently active and available for new subscriptions.
    /// </summary>
    public IsActive IsActive { get; set; }
    /// <summary>
    /// Time duration for the plan
    /// </summary>
    public int Duration { get; set; }
        /// <summary>
    /// Time duration
    /// </summary>
    public decimal Price { get; set; }
    /// <summary>
    /// Date/time record created
    /// </summary>
    public DateTime DateModified { get; set; }

    /// <summary>
    /// Last date/time record changed
    /// </summary>
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    [JsonIgnore] public virtual Subscription? Subscription { get; set; }
}