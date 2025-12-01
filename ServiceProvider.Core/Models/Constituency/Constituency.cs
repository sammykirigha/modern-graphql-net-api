using ServiceProvider.Core.Interfaces.Models;
using System.Text.Json.Serialization;

namespace ServiceProvider.Core.Models;
public class Constituency: IEntity
{
	public Guid Id { get; set; }
	public Guid CountyId { get; set; }
	public string ConstituencyName  {get; set;} = string.Empty;
	public DateTime DateCreated { get; set; }
	public DateTime DateModified { get; set; }
	
	[JsonIgnore] public virtual  County? County { get; set; } 
}