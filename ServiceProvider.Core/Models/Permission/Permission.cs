using System.Text.Json.Serialization;
using ServiceProvider.Core.Interface.Models;
 
namespace ServiceProvider.Core.Models;
 
public class Permission : IEntity
{
    /// <summary>
    /// Primary key
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = "";
    /// <summary>
    /// time/date for creation
    /// </summary>
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    /// <summary>
    /// time/date for updates
    /// </summary>
    public DateTime DateModified { get; set; } = DateTime.UtcNow;
 
    [JsonIgnore] public virtual ICollection<UserPermission> UserPermissions { get; set; } = new List<UserPermission>();
 
    [JsonIgnore] public virtual ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
}