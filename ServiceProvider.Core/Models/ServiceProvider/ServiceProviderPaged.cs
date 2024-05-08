namespace ServiceProvider.Core.Models;

public partial class ServiceProviderPaged {
	public ServiceProvider? ServiceProvider {get; set;}
	public int Count {get; set;}
	public int Total {get; set;}
}