using AutoMapper;
using MediatR;
using SwiftBlog.Api.Core.Application.Dtos.CategoryDto;
using SwiftBlog.Api.Core.Application.Features.CQRS.Queries.Category.List;
using SwiftBlog.Api.Core.Application.Interfaces;
using SwiftBlog.Api.Core.Domain;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Handlers.CategoryList
{
    public class GetCategoryListAllQueryRequestHandler : IRequestHandler<GetAllCategoryListQueryRequest, List<CategoryListDto>>
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;

        public GetCategoryListAllQueryRequestHandler(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<CategoryListDto>> Handle(GetAllCategoryListQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllListAsync();
             return _mapper.Map<List<CategoryListDto>>(data);
        }
    }
}
