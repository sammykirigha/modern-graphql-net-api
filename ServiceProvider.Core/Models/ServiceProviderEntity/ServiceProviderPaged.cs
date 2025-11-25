namespace ServiceProvider.Core.Models.ServiceProvider;

public partial class ServiceProviderEntityPaged {
	public ServiceProviderEntity? ServiceProvider {get; set;}
	public int Count {get; set;}
	public int Total {get; set;}
}