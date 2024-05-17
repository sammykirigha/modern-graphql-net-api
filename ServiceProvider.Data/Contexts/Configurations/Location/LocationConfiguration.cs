using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class LocationConfiguration : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> entity)
    {
        entity.ToTable($"SP_{nameof(Location)}");
        entity.HasKey(x => x.Id);

        entity.Property(x => x.County).HasMaxLength(50);
        entity.Property(x => x.Town).HasMaxLength(50);
        entity.Property(x => x.Area).HasMaxLength(50);

        entity.HasMany(x => x.Clients).WithOne(x => x.Location);
    }
}