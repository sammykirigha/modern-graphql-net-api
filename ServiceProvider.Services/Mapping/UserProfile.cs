using AutoMapper;
using ServiceProvider.Core.DTOs.User;
using ServiceProvider.Core.Models;

public class UserProfileMap : Profile
{
    public UserProfileMap()
    {
        CreateMap<CreateUserDTO, User>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(_ => Guid.NewGuid()))
            .ForMember(dest => dest.DateCreated, opt => opt.MapFrom(_ => DateTime.UtcNow))
            .ForMember(dest => dest.DateModified, opt => opt.MapFrom(_ => DateTime.UtcNow));
    }
}