using System.Text.Json.Serialization;
using ServiceProvider.Core.Interface.Models;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Models;

public partial class UserPermission : IEntity
{
    /// <summary>
    /// Primary key
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Id of user (foreign key)
    /// </summary>
    public Guid UserId { get; set; }
    /// <summary>
    /// Id of Permission (foreign key)
    /// </summary>
    public Guid PermissionId { get; set; }
    /// <summary>
    /// Date/time record created
    /// </summary>
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    /// <summary>
    /// Last date/time record changed
    /// </summary>
    public DateTime DateModified { get; set; } = DateTime.UtcNow;
    [JsonIgnore] public virtual User User { get; set; } = null!;
    [JsonIgnore] public virtual Permission? Permission { get; set; } = null!;
}