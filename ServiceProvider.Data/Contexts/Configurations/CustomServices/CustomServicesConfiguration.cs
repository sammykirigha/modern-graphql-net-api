using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class CustomServiceConfiguration : IEntityTypeConfiguration<CustomService>
{
	public void Configure(EntityTypeBuilder<CustomService> entity)
	{
		entity.ToTable($"SP_{nameof(CustomService)}");
		entity.HasKey(x => x.Id);
        
	}
}