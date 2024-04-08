using System.Text.Json.Serialization;
using ServiceProvider.Core.Interfaces.Models;
 
namespace ServiceProvider.Core.Models;
public partial class Role : IEntity
{
    /// <summary>
    /// Primary key
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// Name of role
    /// </summary>
    public string Name { get; set; } = "";
    /// <summary>
    /// Date/time record created
    /// </summary>
    public DateTime DateModified { get; set; }

    /// <summary>
    /// Last date/time record changed
    /// </summary>
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
 
    [JsonIgnore] public virtual ICollection<User> Users { get; set; } = new List<User>();
   
    [JsonIgnore] public virtual ICollection<RolePermission> Permissions { get; set; } = new List<RolePermission>();
 
}