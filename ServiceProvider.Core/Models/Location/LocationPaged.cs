namespace ServiceProvider.Core.Models;
public partial class LocationPaged {
    public Location? Location {get; set;}
    public int Count {get; set;}
    public int Total {get; set;}
}