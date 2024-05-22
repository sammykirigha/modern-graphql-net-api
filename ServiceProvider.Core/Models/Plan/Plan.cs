using ServiceProvider.Core.Interfaces.Models;

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
    /// Time duration for the plan
    /// </summary>
    public TimeSpan Duration { get; set; }
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
}