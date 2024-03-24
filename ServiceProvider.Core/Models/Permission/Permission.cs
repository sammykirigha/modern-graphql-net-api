using System.Text.Json.Serialization;

namespace ServiceProvider.Core.Models;

public class Permission : IEntity
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }

    [JsonIgnore] public virtual ICollection<UserPermission> UserPermissions { get; set; } = new List<UserPermission>();
    [JsonIgnore] public virtual ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();

}