
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class ServiceConfiguration : IEntityTypeConfiguration<Service>
{
    public void Configure(EntityTypeBuilder<Service> entity)
    {
        entity.ToTable($"SP_{nameof(Service)}");
        entity.HasKey(x => x.Id);
        entity.Property(x => x.Name).HasMaxLength(50);

        entity.HasOne(x => x.Category)
            .WithMany(x => x.Services);
            
    }
}