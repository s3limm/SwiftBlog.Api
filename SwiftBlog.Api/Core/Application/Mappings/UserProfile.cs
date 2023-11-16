using AutoMapper;
using SwiftBlog.Api.Core.Application.Dtos.AppUserDto;
using SwiftBlog.Api.Core.Domain;

namespace SwiftBlog.Api.Core.Application.Mappings
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<AppUserListDto, AppUser>().ReverseMap();
        }
    }
}
