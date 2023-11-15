using MediatR;
using SwiftBlog.Api.Core.Application.Features.CQRS.Commands.Category.Update;
using SwiftBlog.Api.Core.Application.Interfaces;
using SwiftBlog.Api.Core.Domain;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Handlers.UpdateCategory
{
    public class UpdateCategoryCommandRequestHandler : IRequestHandler<UpdateCategoryCommandRequest>
    {
        private readonly IRepository<Category> _repository;

        public UpdateCategoryCommandRequestHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByIdAsync(request.Id);
            if(data != null)
            {
                data.Name = request.Name;
                data.Definition = request.Definition;
            }
            await _repository.UpdateAsync(data);
            return Unit.Value;
        }
    }
}
