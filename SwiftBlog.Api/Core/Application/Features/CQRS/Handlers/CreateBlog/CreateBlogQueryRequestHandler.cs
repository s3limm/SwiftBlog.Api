using MediatR;
using SwiftBlog.Api.Core.Application.Dtos.Blog;
using SwiftBlog.Api.Core.Application.Features.CQRS.Commands.Blog.Create;
using SwiftBlog.Api.Core.Application.Interfaces;
using SwiftBlog.Api.Core.Domain;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Handlers.CreateBlog
{
    public class CreateBlogQueryRequestHandler : IRequestHandler<CreateBlogQueryRequest>
    {
        private readonly IRepository<Blog> _repository;

        public CreateBlogQueryRequestHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateBlogQueryRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Blog
            {
                Title = request.Title,
                Content = request.Content,
                Description = request.Description,
                AppUserId = request.AppUserId,
                CategoryId = request.CategoryId,
            });

            return Unit.Value;
        }
    }
}
