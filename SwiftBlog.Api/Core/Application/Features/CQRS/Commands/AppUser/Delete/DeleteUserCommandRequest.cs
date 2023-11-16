using MediatR;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Commands.AppUser.Delete
{
    public class DeleteUserCommandRequest :IRequest
    {
        public DeleteUserCommandRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }

    }
}
