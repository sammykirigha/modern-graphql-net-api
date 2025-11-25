using Microsoft.EntityFrameworkCore;
using ServiceProvider.Core.Enums;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Data.Contexts.Seeding;

public static partial class DataSeeding
{
    public static void AddUserSeeding(ModelBuilder builder)
    {
        // user
        builder.Entity<User>().HasData(
        new User()
        {
            Id = new Guid("dcfaff46-e2c3-4b3d-ba44-dfe86b9dfcd3"),
            IsActive = true,
            FirstName = "ADM",
            LastName = "Admin",
            Email = "admin@none.com",
            Password = "AdminPassword123!",
            DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
            DateModified = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
        });

        builder.Entity<User>().HasData(
        new User
        {
            Id = new Guid("17ff54a6-9d9a-45dc-95ea-10b68b9e6378"),

            IsActive = true,
            FirstName = "Sam",
            LastName = "Admin",
            Password = "AdminPassword123!",
            Email = "sam@none.com",
            DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
            DateModified = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
        });
        builder.Entity<User>().HasData(
        new User
        {
            Id = new Guid("4315515f-9932-49b7-a01d-7261047ed1c9"),
            IsActive = true,
            FirstName = "Dorcis",
            LastName = "Admin",
            Email = "dorcis@none.com",
            Password = "AdminPassword123!",
            DateCreated = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
            DateModified = new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc),
        });
    }
}