using MediatR;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SwiftBlog.Api.Core.Application.Features.CQRS.Commands.AppUser.Delete;
using SwiftBlog.Api.Core.Application.Interfaces;
using SwiftBlog.Api.Core.Domain;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Handlers.DeleteUser
{
    public class DeleteUserCommandRequestHandler : IRequestHandler<DeleteUserCommandRequest>
    {
        private readonly IRepository<AppUser> _repository;

        public DeleteUserCommandRequestHandler(IRepository<AppUser> repositor)
        {
            _repository = repositor;
        }

        public async Task<Unit> Handle(DeleteUserCommandRequest request, CancellationToken cancellationToken)
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
