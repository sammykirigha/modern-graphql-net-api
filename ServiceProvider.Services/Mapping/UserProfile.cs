using AutoMapper;
using ServiceProvider.Core.DTOs.User;
using ServiceProvider.Core.Models;

namespace ServiceProvider.Services.Mapping;
public class UserProfile : Profile
{
    public UserProfile()
    {
	    CreateMap<CreateUserDto, User>(MemberList.Source).ForMember(dest => dest.Id, opt => opt.Ignore());
        CreateMap<User, CreateUserDto>();
    }
}