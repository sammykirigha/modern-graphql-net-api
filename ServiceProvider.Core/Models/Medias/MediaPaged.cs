namespace ServiceProvider.Core.Models.Medias;
public partial class MediaPaged
{
	public Media? Media {get; set;}
	public int Count {get; set;}
	public int Total {get; set;}
}