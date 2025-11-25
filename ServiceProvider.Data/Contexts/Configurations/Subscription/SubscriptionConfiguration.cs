using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
{
    public void Configure(EntityTypeBuilder<Subscription> entity)
    {
        entity.ToTable($"SP_{nameof(Subscription)}");
        entity.HasKey(x => x.Id);

        entity.HasOne(x => x.ServiceProvider)
            .WithOne(x => x.Subscription);
        entity.HasOne(x => x.Plan)
            .WithOne(x => x.Subscription);
    }
}