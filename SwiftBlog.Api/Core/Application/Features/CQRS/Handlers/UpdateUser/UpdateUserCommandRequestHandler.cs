using MediatR;
using SwiftBlog.Api.Core.Application.Features.CQRS.Commands.AppUser.Update;
using SwiftBlog.Api.Core.Application.Interfaces;
using SwiftBlog.Api.Core.Domain;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Handlers.UpdateUser
{
    public class UpdateUserCommandRequestHandler : IRequestHandler<UpdateUserCommandRequest>
    {
        private readonly IRepository<AppUser> _repository;

        public UpdateUserCommandRequestHandler(IRepository<AppUser> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateUserCommandRequest request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByIdAsync(request.Id);
            if (data != null)
            {
                data.UserName = request.UserName;
                data.Password = request.Password;
                data.AppRoleId = request.AppRoleId;
            }
            await _repository.UpdateAsync(data);
            return Unit.Value;
        }
    }
}
