
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
	public void Configure(EntityTypeBuilder<Client> entity)
	{
		entity.ToTable($"SP_{nameof(Client)}");
		entity.HasKey(x => x.Id);
		entity.Property(x => x.FirstName).HasMaxLength(50);
		entity.Property(x => x.LastName).HasMaxLength(50);
		entity.Property(x => x.Email).HasMaxLength(50);
		entity.Property(x => x.Phone).HasMaxLength(30);

		entity.HasIndex(x => x.Email).IsUnique();
		entity.HasOne(x => x.Location)
			.WithOne(x => x.Client);

	}
}

