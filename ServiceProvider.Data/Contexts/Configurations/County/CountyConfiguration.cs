using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Configurations;

public partial class CountyConfiguration : IEntityTypeConfiguration<County>
{
	public void Configure(EntityTypeBuilder<County> entity)
	{
		entity.ToTable($"SP_{nameof(County)}");
		entity.HasKey(x => x.Id);
        
	}
}