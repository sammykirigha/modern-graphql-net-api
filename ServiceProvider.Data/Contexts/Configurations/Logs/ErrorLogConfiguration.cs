using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public class ErrorLogConfiguration : IEntityTypeConfiguration<ErrorLog>
{
    public void Configure(EntityTypeBuilder<ErrorLog> entity)
    {
        entity.ToTable($"SP_{nameof(ErrorLog)}");
        entity.HasKey(x => x.Id);

        entity.Property(x => x.Type).HasMaxLength(100);
        entity.Property(x => x.Message).HasMaxLength(1000);
        entity.Property(x => x.ActiveUserName).HasMaxLength(100);
        entity.Property(x => x.LoggedInUserName).HasMaxLength(100);

        entity.HasOne(x => x.ActiveUser)
            .WithMany(x => x.ErrorLogsActive);
        entity.HasOne(x => x.LoggedInUser)
            .WithMany(x => x.ErrorLogsLoggedIn);
    }
}

