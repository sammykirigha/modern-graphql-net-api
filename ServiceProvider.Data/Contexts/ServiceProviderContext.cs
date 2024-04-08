
using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Interfaces.Models;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts.Seeding;

namespace ServiceProvider.Data.Contexts;

public partial class ServiceProviderContext(DbContextOptions<ServiceProviderContext> options) : DbContext(options)
{
    // ** ENTITIES **
  // logs
  	public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
	public virtual DbSet<EntityLog> EntityLogs { get; set; }
	public virtual DbSet<LoginLog> LoginLogs { get; set; }

    // user
	public virtual DbSet<User> Users { get; set; }
	public virtual DbSet<UserPermission> UserPermissions { get; set; }

    // Role
    public virtual DbSet<Role> Roles { get; set; }
    public virtual DbSet<RolePermission> RolePermissions { get; set; }

    // Permission
    public virtual DbSet<Permission> Permissions { get; set; }
    
    // ********** OnModelCreating **********
    protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.HasDefaultSchema("sp");
		
		// user
		modelBuilder.ApplyConfiguration(new Configurations.UserConfiguration());
		modelBuilder.ApplyConfiguration(new Configurations.UserPermissionConfiguration());
		
		// role
		modelBuilder.ApplyConfiguration(new Configurations.RoleConfiguration());
		modelBuilder.ApplyConfiguration(new Configurations.RolePermissionConfiguration());
		
		// permission
		modelBuilder.ApplyConfiguration(new Configurations.PermissionConfiguration());
		
		//logs
		modelBuilder.ApplyConfiguration(new Configurations.ErrorLogConfiguration());
		modelBuilder.ApplyConfiguration(new Configurations.EntityLogConfiguration());
		modelBuilder.ApplyConfiguration(new Configurations.LoginLogConfiguration());
		
		// seeding
		DataSeeding.AddUserSeeding(modelBuilder);
	}
    
	protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
	{
		base.ConfigureConventions(configurationBuilder);

		configurationBuilder.Properties<decimal>()
			.HaveColumnType("decimal(19,4)");
		configurationBuilder.Properties<DateTime>()
			.HaveColumnType("datetime2(3)");
	}
	
	// ** METHODS **
	public void AttachModified<T>(T entity) where T : class, IEntity
	{
		var existingEntry = Set<T>().Local.FindEntry(entity.Id);
		if (existingEntry != null)
			existingEntry.CurrentValues.SetValues(entity);
		else
			Entry(entity).State = EntityState.Modified;
	}
}