using AutoMapper;
using SwiftBlog.Api.Core.Application.Dtos.BlogDto;
using SwiftBlog.Api.Core.Application.Dtos.CategoryDto;
using SwiftBlog.Api.Core.Domain;

namespace SwiftBlog.Api.Core.Application.Mappings
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryListDto,Category>().ReverseMap();
        }
    }
}
