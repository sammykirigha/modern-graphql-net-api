using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Seeding;

public partial class ServicesSeeding
{
	public static void AddServicesSeeding(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Service>().HasData(
			new Service
			{
				Id = Guid.NewGuid(),
				CategoryId = CategoriesIds.CleaningHousekeepingGuid,
				Name = "Home Cleaning",
				Description = "Comprehensive home cleaning services including dusting, vacuuming, mopping, and sanitizing all rooms.",
				DateCreated = DateTime.UtcNow,
				DateModified = DateTime.UtcNow
			},
			new Service
			{
				Id = Guid.NewGuid(),
				CategoryId = CategoriesIds.CleaningHousekeepingGuid,
				Name = "Office Cleaning",
				Description = "Professional office cleaning services tailored to maintain a clean and productive work environment.",
				DateCreated = DateTime.UtcNow,
				DateModified = DateTime.UtcNow
			},
			new Service
			{
				Id = Guid.NewGuid(),
				CategoryId = CategoriesIds.CleaningHousekeepingGuid,
				Name = "Carpet Cleaning",
				Description = "Specialized carpet cleaning services using advanced techniques to remove dirt, stains, and allergens.",
				DateCreated = DateTime.UtcNow,
				DateModified = DateTime.UtcNow
			},
			new Service
			{
				Id = Guid.NewGuid(),
				CategoryId = CategoriesIds.CleaningHousekeepingGuid,
				Name = "Window Cleaning",
				Description = "Professional window cleaning services for residential and commercial properties, ensuring streak-free results.",
				DateCreated = DateTime.UtcNow,
				DateModified = DateTime.UtcNow
			},
			new Service
			{
				Id = Guid.NewGuid(),
				CategoryId = CategoriesIds.JuaKaliGeneralRepairsGuid,
				Name = "Plumbing (leak fixes, installations)",
				Description = "Expert plumbing services including leak repairs, fixture installations, and maintenance for residential and commercial properties.",
				DateCreated = DateTime.UtcNow,
				DateModified = DateTime.UtcNow
			},
			new Service
			{
				Id = Guid.NewGuid(),
				CategoryId = CategoriesIds.JuaKaliGeneralRepairsGuid,
				Name = "Electrical Repairs & Installations",
				Description = "Comprehensive electrical services including repairs, installations, and maintenance for homes and businesses.",
				DateCreated = DateTime.UtcNow,
				DateModified = DateTime.UtcNow
			},
			new Service
			{
				Id = Guid.NewGuid(),
				CategoryId = CategoriesIds.JuaKaliGeneralRepairsGuid,
				Name = "Carpentry Services",
				Description = "Professional carpentry services including furniture making, repairs, and custom woodwork for residential and commercial clients.",
				DateCreated = DateTime.UtcNow,
				DateModified = DateTime.UtcNow
			},
			new Service
			{
				Id = Guid.NewGuid(),
				CategoryId = CategoriesIds.JuaKaliGeneralRepairsGuid,
				Name = "Painting & Decorating",
				Description = "Expert painting and decorating services for interior and exterior spaces, enhancing the aesthetic appeal of homes and businesses.",
				DateCreated = DateTime.UtcNow,
				DateModified = DateTime.UtcNow
			},
			new Service
			{
				Id = Guid.NewGuid(),
				CategoryId = CategoriesIds.RideHailingDeliveryServicesGuid,
				Name = "Parcel Delivery (door-to-door, within city)",
				Description = "Reliable parcel delivery services offering door-to-door delivery within the city, ensuring timely and secure transport of packages.",
				DateCreated = DateTime.UtcNow,
				DateModified = DateTime.UtcNow
			},
			new Service
			{
				Id = Guid.NewGuid(),
				CategoryId = CategoriesIds.RideHailingDeliveryServicesGuid,
				Name = "Food Delivery",
				Description = "Efficient food delivery services partnering with local restaurants to bring meals directly to customers' doorsteps.",
				DateCreated = DateTime.UtcNow,
				DateModified = DateTime.UtcNow
			},
			new Service
			{
				Id = Guid.NewGuid(),
				CategoryId = CategoriesIds.RideHailingDeliveryServicesGuid,
				Name = "Ride Hailing (in-city transport)",
				Description = "Convenient ride-hailing services providing safe and reliable transportation within the city for individuals and groups.",
				DateCreated = DateTime.UtcNow,
				DateModified = DateTime.UtcNow
			},
			new Service
			{
				Id = Guid.NewGuid(),
				CategoryId = CategoriesIds.RideHailingDeliveryServicesGuid,
				Name = "Grocery Delivery",
				Description = "Fast and reliable grocery delivery services bringing fresh produce and essentials directly to customers' homes.",
				DateCreated = DateTime.UtcNow,
				DateModified = DateTime.UtcNow
			},
			new Service
			{
				Id = Guid.NewGuid(),
				CategoryId = CategoriesIds.ProfessionalDigitalServicesGuid,
				Name = "Digital Marketing Services",
				Description = "Comprehensive digital marketing solutions including SEO, social media management, and online advertising to boost your online presence.",
				DateCreated = DateTime.UtcNow,
				DateModified = DateTime.UtcNow
			},
			new Service
			{
				Id = Guid.NewGuid(),
				CategoryId = CategoriesIds.ProfessionalDigitalServicesGuid,
				Name = "Graphic Design",
				Description = "Creative graphic design services for branding, marketing materials, and digital content to effectively communicate your message.",
				DateCreated = DateTime.UtcNow,
				DateModified = DateTime.UtcNow
			},
			new Service
			{
				Id = Guid.NewGuid(),
				CategoryId = CategoriesIds.ProfessionalDigitalServicesGuid,
				Name = "Web Development",
				Description = "Professional web development services to create responsive, user-friendly websites tailored to your business needs.",
				DateCreated = DateTime.UtcNow,
				DateModified = DateTime.UtcNow
			},
			new Service
			{
				Id = Guid.NewGuid(),
				CategoryId = CategoriesIds.ProfessionalDigitalServicesGuid,
				Name = "IT Support Services",
				Description = "Reliable IT support services including troubleshooting, network setup, and maintenance for businesses and individuals.",
				DateCreated = DateTime.UtcNow,
				DateModified = DateTime.UtcNow
			},
			new Service
			{
				Id = Guid.NewGuid(),
				CategoryId = CategoriesIds.ProfessionalDigitalServicesGuid,
				Name = "Social Media Management (SMM)",
				Description = "Expert social media management services to enhance your brand's online presence and engage with your audience effectively.",
				DateCreated = DateTime.UtcNow,
				DateModified = DateTime.UtcNow
			},
			new Service
			{
				Id = Guid.NewGuid(),
				CategoryId = CategoriesIds.CateringEventServicesGuid,
				Name = "Event Catering (weddings, corporate)",
				Description = "Professional event catering services for weddings, corporate events, and special occasions, offering customized menus and exceptional service.",
				DateCreated = DateTime.UtcNow,
				DateModified = DateTime.UtcNow
			},
			new Service
			{
				Id = Guid.NewGuid(),
				CategoryId = CategoriesIds.CateringEventServicesGuid,
				Name = "Photography & Videography (events, portraits)",
				Description = "Expert photography and videography services capturing memorable moments at events and creating stunning portraits for individuals and families.",
				DateCreated = DateTime.UtcNow,
				DateModified = DateTime.UtcNow
			},
			new Service
			{
				Id = Guid.NewGuid(),
				CategoryId = CategoriesIds.CateringEventServicesGuid,
				Name = "Decorator Services (party, function setup)",
				Description = "Professional decorator services for parties and functions, providing creative setups and themes to enhance the event atmosphere.",
				DateCreated = DateTime.UtcNow,
				DateModified = DateTime.UtcNow
			},
			new Service
			{
				Id = Guid.NewGuid(),
				CategoryId = CategoriesIds.CateringEventServicesGuid,
				Name = "Ushering & Event Staffing",
				Description = "Reliable ushering and event staffing services to ensure smooth operations and excellent guest experiences at your events.",
				DateCreated = DateTime.UtcNow,
				DateModified = DateTime.UtcNow
			},
			new Service
			{
				Id = Guid.NewGuid(),
				CategoryId = CategoriesIds.BeautySpsPersonalCareServices,
				Name = "Beauty & Spa Services",
				Description = "Professional beauty and spa services including facials, manicure, hairdressing, massages, and skincare treatments to promote relaxation and wellness.",
				DateCreated = DateTime.UtcNow,
				DateModified = DateTime.UtcNow
			},
			new Service
			{
				Id = Guid.NewGuid(),
				CategoryId = CategoriesIds.BeautySpsPersonalCareServices,
				Name = "Fitness & Wellness Services",
				Description = "Comprehensive fitness and wellness services including personal training, yoga & gym classes, and nutrition counseling to help you achieve your health goals.",
				DateCreated = DateTime.UtcNow,
				DateModified = DateTime.UtcNow
			}

		);
	}
}