using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class SubscriptionPaymentsConfiguration : IEntityTypeConfiguration<SubscriptionPayments>
{
    public void Configure(EntityTypeBuilder<SubscriptionPayments> entity)
    {
        entity.ToTable($"SP_{nameof(SubscriptionPayments)}");
        entity.HasKey(x => x.Id);

        entity.HasOne(x => x.Subscription).WithOne(x => x.SubscriptionPayments).OnDelete(DeleteBehavior.NoAction);
        entity.HasOne(x => x.Payment).WithOne(x => x.SubscriptionPayments).OnDelete(DeleteBehavior.NoAction);
    }
}