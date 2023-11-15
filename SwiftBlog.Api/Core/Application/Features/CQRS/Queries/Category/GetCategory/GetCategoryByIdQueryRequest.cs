using MediatR;
using SwiftBlog.Api.Core.Application.Dtos.CategoryDto;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Queries.Category.GetCategory
{
    public class GetCategoryByIdQueryRequest:IRequest<CategoryListDto>
    {
        public GetCategoryByIdQueryRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
