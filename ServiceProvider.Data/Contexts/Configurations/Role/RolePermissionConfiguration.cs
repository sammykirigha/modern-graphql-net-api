

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class RolePermissionConfiguration : IEntityTypeConfiguration<RolePermission>
{
    public void Configure(EntityTypeBuilder<RolePermission> entity)
    {
        entity.ToTable($"SP_{nameof(RolePermission)}");
        entity.HasKey(x => x.Id);

        entity.HasOne(x => x.Permission)
            .WithMany(x => x.RolePermissions);
        entity.HasOne(x => x.Role)
            .WithMany(x => x.Permissions);
    }
}

