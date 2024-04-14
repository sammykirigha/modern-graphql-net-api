using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class ServiceLocationConfiguration : IEntityTypeConfiguration<ServiceLocation>
{
    public void Configure(EntityTypeBuilder<ServiceLocation> entity)
    {
        entity.ToTable($"SP_{nameof(ServiceLocation)}");
        entity.HasKey(x => x.Id);

        entity.HasOne(x => x.Service)
        .WithMany(x => x.Locations);

        entity.HasOne(x => x.Location)
        .WithMany(x => x.ServiceLocations);
    }
}