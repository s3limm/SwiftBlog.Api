using AutoMapper;
using MediatR;
using SwiftBlog.Api.Core.Application.Dtos.BlogDto;
using SwiftBlog.Api.Core.Application.Dtos.CategoryDto;
using SwiftBlog.Api.Core.Application.Features.CQRS.Queries.Category.GetCategory;
using SwiftBlog.Api.Core.Application.Interfaces;
using SwiftBlog.Api.Core.Domain;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Handlers.GetCategoryById
{
    public class GetCategoryByIdQueryRequestHandler : IRequestHandler<GetCategoryByIdQueryRequest, CategoryListDto>
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;

        public GetCategoryByIdQueryRequestHandler(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CategoryListDto> Handle(GetCategoryByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByFilterAsync(x=>x.Id == request.Id);
            return _mapper.Map<CategoryListDto>(data);
        }
    }
}
