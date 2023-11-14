using MediatR;
using SwiftBlog.Api.Core.Domain;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Commands.Blog.Create
{
    public class CreateBlogCommandRequest:IRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public int AppUserId { get; set; }

    }
}
