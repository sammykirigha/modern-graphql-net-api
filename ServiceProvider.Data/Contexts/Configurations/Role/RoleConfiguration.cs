using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> entity)
    {
        entity.ToTable($"SP_{nameof(Role)}");
        entity.HasKey(x => x.Id);

        entity.Property(x => x.Name).HasMaxLength(50);
        entity.HasMany(x => x.Permissions)
            .WithOne(x => x.Role);
    }
}