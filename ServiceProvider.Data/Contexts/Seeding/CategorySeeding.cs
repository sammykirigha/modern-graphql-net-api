using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Seeding;

public static partial class CategorySeeding
{
	public static void  AddCategorySeeding(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Category>().HasData(
			new Category
			{
				Id = CategoriesIds.CleaningHousekeepingGuid,
				Name = "Cleaning & Housekeeping",
				DateModified = DateTime.UtcNow,
				DateCreated = DateTime.UtcNow
			},
			new Category
			{
				Id = CategoriesIds.LandscapingGardeningGuid,
				Name = "Landscaping & Gardening",
				DateModified = DateTime.UtcNow,
				DateCreated = DateTime.UtcNow
			},
			new Category
			{
				Id = CategoriesIds.JuaKaliGeneralRepairsGuid,
				Name = "Jua Kali & General Repairs",
				DateModified = DateTime.UtcNow,
				DateCreated = DateTime.UtcNow
			},
			new Category
			{
				Id = CategoriesIds.RideHailingDeliveryServicesGuid,
				Name = "Ride Hailing & Delivery Services",
				DateModified = DateTime.UtcNow,
				DateCreated = DateTime.UtcNow
			},
			new Category
			{
				Id = CategoriesIds.CateringEventServicesGuid,
				Name = "Catering & Event Services",
				DateModified = DateTime.UtcNow,
				DateCreated = DateTime.UtcNow
			},
			new Category
			{
				Id = CategoriesIds.TutoringEducationalServicesGuid,
				Name = "Tutoring & Educational Services",
				DateModified = DateTime.UtcNow,
				DateCreated = DateTime.UtcNow
			},
			new Category
			{
				Id = CategoriesIds.FitnessWellnessServicesGuid,
				Name = "Fitness & Wellness Services",
				DateModified = DateTime.UtcNow,
				DateCreated = DateTime.UtcNow
			},
			new Category
			{
				Id = CategoriesIds.BeautySpsPersonalCareServices,
				Name = "Beauty, SPA & Personal Care Services",
				DateModified = DateTime.UtcNow,
				DateCreated = DateTime.UtcNow
			},
			new Category
			{
				Id = CategoriesIds.WebITSupportServicesGuid,
				Name = "Web & IT Support Services",
				DateModified = DateTime.UtcNow,
				DateCreated = DateTime.UtcNow
			},
			new Category
			{
				Id = CategoriesIds.ProfessionalDigitalServicesGuid,
				Name = "Professional & Digital Services",
				DateModified = DateTime.UtcNow,
				DateCreated = DateTime.UtcNow
			}
		);
	}
}