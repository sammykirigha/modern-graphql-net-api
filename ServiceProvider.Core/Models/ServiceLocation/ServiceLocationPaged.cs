namespace ServiceProvider.Core.Models;
public partial class ServiceLocationPaged {
    public ServiceLocation? ServiceLocation {get; set;}
    public int Count {get; set;}
    public int Total {get; set;}
}