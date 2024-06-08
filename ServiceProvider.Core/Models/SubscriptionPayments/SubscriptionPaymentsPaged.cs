namespace ServiceProvider.Core.Models;

public partial class SubscriptionPaymentsPaged
{
    public SubscriptionPayments? SubscriptionPayments {get; set;}

    public int Count {get; set;}
    public int Total {get; set;}
}