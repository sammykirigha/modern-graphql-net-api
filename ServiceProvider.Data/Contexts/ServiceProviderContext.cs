using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Interfaces.Models;
using ServiceProvider.Core.Models;
using ServiceProvider.Data.Contexts.Seeding;
using System;

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
    
    // categories
    public virtual DbSet<Category> Categories { get; set; }
    
    //locations
    public virtual DbSet<Location> Locations { get; set; }
    
    //services
    public virtual DbSet<Service> Services { get; set; }
    public virtual DbSet<ServiceLocation> ServiceLocations { get; set; }
    
    //service provider client
    public virtual DbSet<Client> Clients { get; set; }
    public virtual DbSet<ClientsServices> ClientsServices { get; set; }

	//plan
	public virtual DbSet<Plan> Plans { get; set; }
    
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
		
		//service
		modelBuilder.ApplyConfiguration(new Configurations.ServiceConfiguration());
		modelBuilder.ApplyConfiguration(new Configurations.ServiceLocationConfiguration());
		
		//category
		modelBuilder.ApplyConfiguration(new Configurations.CategoryConfiguration());
		
		//category
		modelBuilder.ApplyConfiguration(new Configurations.LocationConfiguration());
		
		modelBuilder.ApplyConfiguration(new Configurations.ClientConfiguration());
		modelBuilder.ApplyConfiguration(new Configurations.ClientsServicesConfiguration());
		//service provider client

		modelBuilder.ApplyConfiguration(new Configurations.PlanConfiguration());
		
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