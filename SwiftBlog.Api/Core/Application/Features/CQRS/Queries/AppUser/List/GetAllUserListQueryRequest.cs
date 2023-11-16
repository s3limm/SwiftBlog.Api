using MediatR;
using SwiftBlog.Api.Core.Application.Dtos.AppUserDto;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Queries.AppUser.List
{
    public class GetAllUserListQueryRequest:IRequest<List<AppUserListDto>>
    {

    }
}
