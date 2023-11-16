using AutoMapper;
using MediatR;
using SwiftBlog.Api.Core.Application.Dtos.AppUserDto;
using SwiftBlog.Api.Core.Application.Features.CQRS.Queries.AppUser.GetUser;
using SwiftBlog.Api.Core.Application.Interfaces;
using SwiftBlog.Api.Core.Domain;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Handlers.GetUserById
{
    public class GetUserByIdQueryRequestHandler : IRequestHandler<GetUserByIdQueryRequest, AppUserListDto>
    {
        private readonly IRepository<AppUser> _repository;
        private readonly IMapper _mapper;

        public GetUserByIdQueryRequestHandler(IRepository<AppUser> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<AppUserListDto> Handle(GetUserByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByFilterAsync(x=>x.Id == request.Id);
            return _mapper.Map<AppUserListDto>(data);
        }
    }
}
