using MediatR;
using SwiftBlog.Api.Core.Application.Dtos.AppUserDto;
using SwiftBlog.Api.Core.Application.Interfaces;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Commands.AppUser.Create
{
    public class CreateUserCommandRequest : IRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int AppRoleId { get; set; }
    }
}
