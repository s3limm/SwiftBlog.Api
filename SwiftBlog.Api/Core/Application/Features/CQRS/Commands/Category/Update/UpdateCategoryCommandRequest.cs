using MediatR;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Commands.Category.Update
{
    public class UpdateCategoryCommandRequest : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Definition { get; set; }
    }
}
