using MediatR;
using SwiftBlog.Api.Core.Application.Dtos.AppUserDto;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Queries.AppUser.GetUser
{
    public class GetUserByIdQueryRequest : IRequest<AppUserListDto>
    {
        public GetUserByIdQueryRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}