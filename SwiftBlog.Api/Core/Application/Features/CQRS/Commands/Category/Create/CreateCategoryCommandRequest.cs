using MediatR;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Commands.Category.Create
{
    public class CreateCategoryCommandRequest:IRequest
    {
        public string Name { get; set; }
        public string Definition { get; set; }
    }
}
