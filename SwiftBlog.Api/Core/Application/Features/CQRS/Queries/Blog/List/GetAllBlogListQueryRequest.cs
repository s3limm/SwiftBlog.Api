using MediatR;
using SwiftBlog.Api.Core.Application.Dtos.Blog;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Queries.Blog.GetAllBlogListRequest
{
    public class GetAllBlogListQueryRequest:IRequest<List<BlogListDto>>
    {

    }
}
