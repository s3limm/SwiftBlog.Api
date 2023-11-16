using MediatR;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Commands.AppUser.Update
{
    public class UpdateUserCommandRequest:IRequest
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int AppRoleId { get; set; }
    }
}
