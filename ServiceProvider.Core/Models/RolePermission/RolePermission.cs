using System.Text.Json.Serialization;
using ServiceProvider.Core.Interfaces.Models;
 
namespace ServiceProvider.Core.Models;
public partial class RolePermission : IEntity
{
    /// <summary>
    /// Primary key
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Id of client (foreign key)
    /// </summary>
    public Guid RoleId { get; set; }
    /// <summary>
    /// Date/time record created
    /// </summary>
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    /// <summary>
    /// Id of Permission (foreign key)
    /// </summary>
    public Guid? PermissionId { get; set; }
    /// <summary>
    /// Last date/time record changed
    /// </summary>
    public DateTime DateModified { get; set; } = DateTime.UtcNow;
 
    [JsonIgnore] public virtual Role Role { get; set; } = null!;
    [JsonIgnore] public virtual Permission? Permission { get; set; }
}