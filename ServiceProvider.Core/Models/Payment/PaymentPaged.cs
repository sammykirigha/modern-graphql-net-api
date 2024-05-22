namespace ServiceProvider.Core.Models;

public partial class PaymentPaged
{
    public Payment? Payment {get; set;}
    public int Count {get; set;}
    public int Total {get; set;}
}