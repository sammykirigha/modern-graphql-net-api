namespace ServiceProvider.Core.Models;

public partial class SubscriptionPaged
{
    public Subscription? Subscription {get; set;}

    public int Count {get; set;}
    public int Total {get; set;}
}