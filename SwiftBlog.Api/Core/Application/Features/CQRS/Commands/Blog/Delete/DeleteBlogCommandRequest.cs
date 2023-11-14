using MediatR;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Commands.Blog.Delete
{
    public class DeleteBlogCommandRequest:IRequest
    {
        public DeleteBlogCommandRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
