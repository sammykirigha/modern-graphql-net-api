using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class LoginLogConfiguration : IEntityTypeConfiguration<LoginLog>
{
    public void Configure(EntityTypeBuilder<LoginLog> entity)
    {
        entity.ToTable($"SP_{nameof(LoginLog)}");
        entity.HasKey(x => x.Id);

        entity.Property(x => x.Username).HasMaxLength(100);
        entity.Property(x => x.Reason).HasMaxLength(50);

        entity.HasOne(x => x.User)
            .WithMany(x => x.LoginLogs);
    }
}
