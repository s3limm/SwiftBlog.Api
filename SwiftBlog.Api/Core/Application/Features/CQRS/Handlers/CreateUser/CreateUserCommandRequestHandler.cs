using MediatR;
using SwiftBlog.Api.Core.Application.Features.CQRS.Commands.AppUser.Create;
using SwiftBlog.Api.Core.Application.Interfaces;
using SwiftBlog.Api.Core.Domain;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Handlers.CreateUser
{
    public class CreateUserCommandRequestHandler : IRequestHandler<CreateUserCommandRequest>
    {
        private readonly IRepository<AppUser> _repository;

        public CreateUserCommandRequestHandler(IRepository<AppUser> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new AppUser
            {
                UserName = request.UserName,
                Password = request.Password,
                AppRoleId = request.AppRoleId,
            });
            return Unit.Value;
        }
    }
}
