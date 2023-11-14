using MediatR;
using SwiftBlog.Api.Core.Application.Features.CQRS.Commands.Blog.Update;
using SwiftBlog.Api.Core.Application.Interfaces;
using SwiftBlog.Api.Core.Domain;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Handlers.UpdateBlog
{
    public class UpdateBlogCommandRequestHandler : IRequestHandler<UpdateBlogCommandRequest>
    {
        private readonly IRepository<Blog> _repository;

        public UpdateBlogCommandRequestHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateBlogCommandRequest request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByIdAsync(request.Id);
            if(data != null)
            {
                data.Title = request.Title;
                data.Description = request.Description;
                data.Content = request.Content;
                data.CategoryId = request.CategoryId;
                data.AppUserId = request.AppUserId;
            }
            await _repository.UpdateAsync(data);
            return Unit.Value;
        }
    }
}
