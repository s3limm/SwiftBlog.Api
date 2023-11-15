using AutoMapper;
using SwiftBlog.Api.Core.Application.Dtos.BlogDto;
using SwiftBlog.Api.Core.Domain;

namespace SwiftBlog.Api.Core.Application.Mappings
{
    public class BlogProfile : Profile
    {
        public BlogProfile()
        {
            CreateMap<BlogListDto,Blog>().ReverseMap();
        }
    }
}
