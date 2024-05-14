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

        entity.HasOne(sl => sl.Service)
        .WithMany(s => s.ServiceLocations)
        .HasForeignKey(sl => sl.ServiceId)
        .OnDelete(DeleteBehavior.Cascade);
        

        entity.HasOne(sl => sl.Location)
        .WithMany(l => l.ServiceLocations)
        .HasForeignKey(sl => sl.LocationId)
        .OnDelete(DeleteBehavior.Cascade);
    }
}