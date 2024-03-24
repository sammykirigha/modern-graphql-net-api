using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class PermissionConfiguration : IEntityTypeConfiguration<Permission>
{
    public void Configure(EntityTypeBuilder<Permission> entity)
    {
        entity.ToTable($"SP_{nameof(Permission)}");
        entity.HasKey(x => x.Id);

        entity.Property(x => x.Name).HasMaxLength(50);
        entity.HasMany(x => x.RolePermissions)
            .WithOne(x => x.Permission);
        entity.HasMany(x => x.UserPermissions)
            .WithOne(x => x.Permission);
    }
}

