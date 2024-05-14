namespace ServiceProvider.Core.Models;
public partial class ClientServicePaged {
    public ClientService? ClientService {get; set;}
    public int Count {get; set;}
    public int Total {get; set;}
}