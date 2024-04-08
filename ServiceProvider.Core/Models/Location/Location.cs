
using ServiceProvider.Core.Interfaces.Models;

namespace ServiceProvider.Core.Models;

public class Location : IEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "";
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
}

