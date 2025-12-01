using ServiceProvider.Core.Interfaces.Models;

namespace ServiceProvider.Core.Models;
public class County : IEntity
{
	public Guid Id { get; set; }
	public string CountyName  {get; set;} = string.Empty;
	public DateTime DateCreated { get; set; }
	public DateTime DateModified { get; set; }
}