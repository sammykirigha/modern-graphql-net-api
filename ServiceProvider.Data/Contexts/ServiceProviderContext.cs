using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Interfaces.Models;
using ServiceProvider.Core.Models;
using ServiceProvider.Core.Models.Medias;
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
	
	//customServices
	public virtual DbSet<CustomService> CustomServices { get; set; }
	
	//county
	public virtual DbSet<County> Counties { get; set; }
	//constituency
	public virtual DbSet<Constituency> Constituencies { get; set; }
	
	//providerLocations
	public virtual DbSet<ProviderLocations> ProviderLocations { get; set; }
	
	//providerServices
	public virtual DbSet<ProviderServices> ProviderServices { get; set; }
	
	//media
	public virtual DbSet<Media> Media { get; set; }
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
    //service provider client
    public virtual DbSet<ServiceProviderEntity> ServiceProviders { get; set; }
	//plan
	public virtual DbSet<Plan> Plans { get; set; }
	public virtual DbSet<Booking> Bookings { get; set; }
	public virtual DbSet<Review> Reviews { get; set; }

	//payment
	public virtual DbSet<Payment> Payments { get; set; }
	public virtual DbSet<Subscription> Subscriptions { get; set; }
    
    // ********** OnModelCreating **********
    protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.HasDefaultSchema("sp");
		
		// user
		modelBuilder.ApplyConfiguration(new Configurations.UserConfiguration());
		modelBuilder.ApplyConfiguration(new Configurations.UserPermissionConfiguration());
		
		modelBuilder.ApplyConfiguration(new Configurations.MediasConfiguration());
		
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
		//category
		modelBuilder.ApplyConfiguration(new Configurations.CategoryConfiguration());

		//booking
		modelBuilder.ApplyConfiguration(new Configurations.BookingConfiguration());
		//review
		modelBuilder.ApplyConfiguration(new Configurations.ReviewConfiguration());
		
		//category
		modelBuilder.ApplyConfiguration(new Configurations.LocationConfiguration());
		
		modelBuilder.ApplyConfiguration(new Configurations.ServiceProviderEntityConfiguration());
		//service provider client

		modelBuilder.ApplyConfiguration(new Configurations.PlanConfiguration());

		//payment
		modelBuilder.ApplyConfiguration(new Configurations.PaymentConfiguration());

		//subscription
		modelBuilder.ApplyConfiguration(new Configurations.SubscriptionConfiguration());
		
		//providerLocations
		modelBuilder.ApplyConfiguration(new Configurations.ProviderLocationsConfiguration());
		//providerServices
		modelBuilder.ApplyConfiguration(new Configurations.ProviderServicesConfiguration());
		
		//customServices
		modelBuilder.ApplyConfiguration(new Configurations.CustomServiceConfiguration());
		
		//county
		modelBuilder.ApplyConfiguration(new Configurations.CountyConfiguration());
		//constituency
		modelBuilder.ApplyConfiguration(new Configurations.ConstituencyConfiguration());
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