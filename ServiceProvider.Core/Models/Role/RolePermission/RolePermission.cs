
using System.Text.Json.Serialization;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Core.Models;

public class RolePermission : IEntity
{
    public Guid Id { get; set; }
    public Guid RoleId { get; set; }
    
    public Guid PermissionId { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }

    [JsonIgnore] public virtual Role Role { get; set; } = null;
    [JsonIgnore] public virtual Permission? Permission { get; set; } = null;
}

