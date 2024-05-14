using ServiceProvider.Core.Interfaces.Models;
using System.Text.Json.Serialization;

namespace ServiceProvider.Core.Models;

public class Location : IEntity
{
    /// <summary>
    /// Primary key
    /// </summary>
    public Guid Id { get; set; }
    /// <summary>
    /// County located eg Nyeri county
    /// </summary>
    public string County { get; set; } = "";
    /// <summary>
    /// Town eg Nyeri town
    /// </summary>
    public string Town {get; set;} = "";
    /// <summary>
    /// Area skuta
    /// </summary>
    public string Area {get; set;} = "";
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }

    [JsonIgnore] public virtual ICollection<ServiceLocation> ServiceLocations { get; set; } = new List<ServiceLocation>();
    [JsonIgnore] public virtual Client?  Client{ get; set; }
}

