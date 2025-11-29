using ServiceProvider.Core.Interfaces.Models;
using System.Text.Json.Serialization;


namespace ServiceProvider.Core.Models;

public class Location : IEntity
{
    public Guid Id { get; set; }
    public string LocationName {get; set;}
    public string ConstituencyId {get; set;}
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
}

