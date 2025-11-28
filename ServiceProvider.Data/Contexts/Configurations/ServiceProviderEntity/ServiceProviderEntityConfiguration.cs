
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;


namespace ServiceProvider.Data.Contexts.Configurations;

public class ServiceProviderEntityConfiguration : IEntityTypeConfiguration<ServiceProviderEntity>
{
	public void Configure(EntityTypeBuilder<ServiceProviderEntity> entity)
	{
		entity.ToTable($"SP_{nameof(ServiceProviderEntity)}");
		entity.HasKey(x => x.Id);
		entity.Property(x => x.FirstName).HasMaxLength(50);
		entity.Property(x => x.LastName).HasMaxLength(50);
		entity.Property(x => x.Email).HasMaxLength(50);
		entity.Property(x => x.Phone).HasMaxLength(30);

		entity.HasIndex(x => x.Email).IsUnique();
		
	}
}

