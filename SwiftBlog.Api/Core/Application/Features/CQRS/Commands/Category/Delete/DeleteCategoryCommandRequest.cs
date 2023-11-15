using MediatR;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Commands.Category.Delete
{
    public class DeleteCategoryCommandRequest:IRequest
    {
        public DeleteCategoryCommandRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
