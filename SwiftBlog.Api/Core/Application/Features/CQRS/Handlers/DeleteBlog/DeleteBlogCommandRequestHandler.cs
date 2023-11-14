using MediatR;
using SwiftBlog.Api.Core.Application.Features.CQRS.Commands.Blog.Delete;
using SwiftBlog.Api.Core.Application.Interfaces;
using SwiftBlog.Api.Core.Domain;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Handlers.DeleteBlog
{
    public class DeleteBlogCommandRequestHandler : IRequestHandler<DeleteBlogCommandRequest>
    {
        private readonly IRepository<Blog> _repository;

        public DeleteBlogCommandRequestHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteBlogCommandRequest request, CancellationToken cancellationToken)
        {
            var blog = await _repository.GetByIdAsync(request.Id);
            if(blog != null)
            {
                await _repository.RemoveAsync(blog);
            }
            return Unit.Value;
        }
    }
}
