
namespace ServiceProvider.Core.Models;

public interface IEntity
{
    public Guid Id { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
}

