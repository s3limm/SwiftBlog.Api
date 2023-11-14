using AutoMapper;
using MediatR;
using SwiftBlog.Api.Core.Application.Dtos.Blog;
using SwiftBlog.Api.Core.Application.Features.CQRS.Queries.Blog.GetAllBlogListRequest;
using SwiftBlog.Api.Core.Application.Interfaces;
using SwiftBlog.Api.Core.Domain;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Handlers.BlogList
{
    public class GetAllBlogListQueryRequestHandler : IRequestHandler<GetAllBlogListQueryRequest, List<BlogListDto>>
    {
        private readonly IRepository<Blog> _repository;
        private readonly IMapper _mapper;

        public GetAllBlogListQueryRequestHandler(IRepository<Blog> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<BlogListDto>> Handle(GetAllBlogListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = _repository.GetAllListAsync();
            return _mapper.Map<List<BlogListDto>>(data);
        }
    }
}
