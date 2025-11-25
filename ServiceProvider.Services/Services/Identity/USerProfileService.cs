using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using ServiceProvider.Core.Enums;
using ServiceProvider.Core.Exceptions;
using ServiceProvider.Core.Extensions;
using ServiceProvider.Core.Interfaces.Repositories;
using ServiceProvider.Core.Interfaces.Services;
using ServiceProvider.Core.Models;

public class UserProfileService(
    IIdentityService _identityService,
    IClaimsUserService _claimsUserService,
    IIdentityRepository _repository,
    IUserProfileCoreService _userProfileCoreService,
    IWebHostEnvironment _env
    
    ) : IUserProfileService
{
    public UserProfile LoggedInUser
    {
        get => _userProfileCoreService.LoggedInUser;
        set => _userProfileCoreService.LoggedInUser = value;
    }
    
    public UserProfile ActiveUser
    {
        get => _userProfileCoreService.ActiveUser;
        set => _userProfileCoreService.ActiveUser = value;
    }

    public async Task<UserProfile> GetUserProfileAsync(Guid? id = null)
    {
        var userId = id ?? _claimsUserService.GetContextUserId();
        if(userId == Guid.Empty)
            return new UserProfile();
        var profile = await _identityService.GetUserProfileAsync(userId);
        
        //for dev purposes: add dev user if not found for development and staging 
        if(profile == null && (_env.IsDevelopment() || _env.IsStaging()))
            profile = await AddDevUserAsync();

        return profile;
    }
    
    public async Task<UserProfile> AddDevUserAsync()
    {
        var id = _claimsUserService.GetContextUserId();
        var claims = _claimsUserService.GetContextUser();

        if (id == Guid.Empty || claims == null)
            return new UserProfile();

        var user = new User()
        {
            Id = id,
            IsActive = true,
            FirstName = claims.GetFirstName(),
            LastName = claims.GetLastName(),
            Email = claims.GetEmail(),
        };
        await _repository.AddDevUserAsync(user);

        var profile = await _identityService.GetUserProfileAsync(id)
                      ?? throw new AppException("ERROR: Dev user not created!");

        return profile;
    }
}