namespace ServiceProvider.Core.Models;
public partial class ServicePaged {
    public Service? Service {get; set;}
    public int Count {get; set;}
    public int Total {get; set;}
}