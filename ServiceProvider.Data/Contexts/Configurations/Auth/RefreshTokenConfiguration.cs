using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models.Auth;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
{
	public void Configure(EntityTypeBuilder<RefreshToken> entity)
	{
		entity.ToTable($"SP_{nameof(RefreshToken)}");
		entity.Property(r => r.Token).HasMaxLength(200);
		entity.HasIndex(r => r.Token).IsUnique();
		entity.HasKey(x => x.Id);
		entity.HasOne(x => x.User).WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);
	}
}