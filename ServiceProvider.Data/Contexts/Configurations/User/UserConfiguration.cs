
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> entity)
    {
        entity.ToTable($"SP_{nameof(User)}");
        entity.HasKey(x => x.Id);
        entity.Property(x => x.FirstName).HasMaxLength(50);
        entity.Property(x => x.LastName).HasMaxLength(50);
        entity.Property(x => x.Email).HasMaxLength(50);

        entity.HasIndex(x => x.Email).IsUnique();

        entity.HasOne(x => x.Role)
            .WithMany(x => x.Users);
    }
}


