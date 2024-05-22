using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> entity)
    {
        entity.ToTable($"SP_{nameof(Payment)}");
        entity.HasKey(x => x.Id);

        entity.HasOne(x => x.User)
            .WithOne(x => x.Payment);
    }
}