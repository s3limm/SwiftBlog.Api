using MediatR;
using SwiftBlog.Api.Core.Application.Dtos.BlogDto;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Queries.Blog.GetById
{
    public class GetBlogByIdQueryRequest : IRequest<BlogListDto>
    {
        public GetBlogByIdQueryRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
