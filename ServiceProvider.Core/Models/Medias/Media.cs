using ServiceProvider.Core.Enums;
using ServiceProvider.Core.Interfaces.Models;

namespace ServiceProvider.Core.Models.Medias;
public partial class Media: IEntity
{
	public Guid Id { get; set; }

	public Guid ServiceProviderId {get; set;}

	public string Url { get; set; } = "";

	 public MediaCategory Category { get; set; }

	public DateTime DateModified { get; set; }

	public DateTime DateCreated { get; set; } = DateTime.UtcNow;
}