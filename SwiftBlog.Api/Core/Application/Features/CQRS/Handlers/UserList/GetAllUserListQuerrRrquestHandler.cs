using AutoMapper;
using MediatR;
using SwiftBlog.Api.Core.Application.Dtos.AppUserDto;
using SwiftBlog.Api.Core.Application.Features.CQRS.Queries.AppUser.List;
using SwiftBlog.Api.Core.Application.Interfaces;
using SwiftBlog.Api.Core.Domain;

namespace SwiftBlog.Api.Core.Application.Features.CQRS.Handlers.UserList
{
    public class GetAllUserListQuerrRrquestHandler : IRequestHandler<GetAllUserListQueryRequest, List<AppUserListDto>>
    {
        private readonly IRepository<AppUser> _repository;
        private readonly IMapper _mapper;

        public GetAllUserListQuerrRrquestHandler(IRepository<AppUser> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<AppUserListDto>> Handle(GetAllUserListQueryRequest request, CancellationToken cancellationToken)
        {
            var list = await _repository.GetAllListAsync();
            return _mapper.Map<List<AppUserListDto>>(list);
        }
    }
}
