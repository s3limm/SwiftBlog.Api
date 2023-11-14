using MediatR;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Commands.Blog.Update
{
    public class UpdateBlogCommandRequest:IRequest
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public int CategoryId { get; set; }
        public int AppUserId { get; set; }
    }
}
