

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class UserPermissionConfiguration : IEntityTypeConfiguration<UserPermission>
{
    public void Configure(EntityTypeBuilder<UserPermission> entity)
    {
        entity.ToTable($"SP_{nameof(UserPermission)}");
        entity.HasKey(x => x.Id);

        entity.HasOne(x => x.User)
            .WithMany(x => x.Permissions);
        entity.HasOne(x => x.Permission)
            .WithMany(x => x.UserPermissions);
    }
}

