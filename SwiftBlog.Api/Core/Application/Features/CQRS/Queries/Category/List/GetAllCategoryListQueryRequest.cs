using MediatR;
using SwiftBlog.Api.Core.Application.Dtos.CategoryDto;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Queries.Category.List
{
    public class GetAllCategoryListQueryRequest:IRequest<List<CategoryListDto>>
    {
    }
}
