namespace ServiceProvider.Core.Models;

public partial class ClientPaged {
	public Client? Client {get; set;}
	public int Count {get; set;}
	public int Total {get; set;}
}