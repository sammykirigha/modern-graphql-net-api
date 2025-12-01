using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class ProviderServicesConfiguration : IEntityTypeConfiguration<ProviderServices>
{
	public void Configure(EntityTypeBuilder<ProviderServices> entity)
	{
		entity.ToTable($"SP_{nameof(ProviderServices)}");
		entity.HasKey(x => new { x.ServiceProviderId, x.ServiceId });

	}
}