namespace ServiceProvider.Core.Enums;

public enum UserAccessLevel : byte
{
    Admin = 0,
    User = 1, 
    SuperAdmin = 2,
    ServiceProvider = 3,
    Employee = 4,
}