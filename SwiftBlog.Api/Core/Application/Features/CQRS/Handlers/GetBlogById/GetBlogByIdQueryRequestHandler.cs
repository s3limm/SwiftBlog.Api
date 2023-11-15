using AutoMapper;
using MediatR;
using SwiftBlog.Api.Core.Application.Dtos.BlogDto;
using SwiftBlog.Api.Core.Application.Features.CQRS.Queries.Blog.GetById;
using SwiftBlog.Api.Core.Application.Interfaces;
using SwiftBlog.Api.Core.Domain;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Handlers.GetBlogById
{
    public class GetBlogByIdQueryRequestHandler : IRequestHandler<GetBlogByIdQueryRequest, BlogListDto>
    {
        private readonly IRepository<Blog> _repository;
        private readonly IMapper _mapper;

        public GetBlogByIdQueryRequestHandler(IRepository<Blog> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<BlogListDto> Handle(GetBlogByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var blog = await _repository.GetByFilterAsync(x=>x.Id == request.Id);
            return _mapper.Map<BlogListDto>(blog);
        }
    }
}
