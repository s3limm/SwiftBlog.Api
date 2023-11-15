using MediatR;
using SwiftBlog.Api.Core.Application.Features.CQRS.Commands.Category.Delete;
using SwiftBlog.Api.Core.Application.Interfaces;
using SwiftBlog.Api.Core.Domain;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Handlers.DeleteCategory
{
    public class DelteCategoryCommandRequestHandler : IRequestHandler<DeleteCategoryCommandRequest>
    {
        private readonly IRepository<Category> _repository;

        public DelteCategoryCommandRequestHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByIdAsync(request.Id);
            if(data != null) 
            {
                await _repository.RemoveAsync(data);
            }
            return Unit.Value;
        }
    }
}
