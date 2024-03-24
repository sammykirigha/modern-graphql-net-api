
using System.Text.Json.Serialization;

namespace ServiceProvider.Core.Models;

public class Role : IEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }

    [JsonIgnore] public virtual ICollection<User> Users { get; set; } = new List<User>();
    [JsonIgnore] public virtual ICollection<RolePermission> Permissions { get; set; } = new List<RolePermission>();
}

