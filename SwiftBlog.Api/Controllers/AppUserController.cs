using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwiftBlog.Api.Core.Application.Features.CQRS.Commands.AppUser.Create;
using SwiftBlog.Api.Core.Application.Features.CQRS.Commands.AppUser.Delete;
using SwiftBlog.Api.Core.Application.Features.CQRS.Commands.AppUser.Update;
using SwiftBlog.Api.Core.Application.Features.CQRS.Queries.AppUser.GetUser;
using SwiftBlog.Api.Core.Application.Features.CQRS.Queries.AppUser.List;

namespace SwiftBlog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AppUserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("List")]
        public async Task<IActionResult> GetAllList()
        {
            var data = await _mediator.Send(new GetAllUserListQueryRequest());
            return Ok(data);
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _mediator.Send(new GetUserByIdQueryRequest(id));
            return Ok(data);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateUserCommandRequest request)
        {
            await _mediator.Send(request);
            return Created("",request.UserName);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateUserCommandRequest request)
        {
            var data = await _mediator.Send(request);
            return Ok(data);
        }

        [HttpDelete("Delete")]

        public async Task<IActionResult> Delete(DeleteUserCommandRequest request)
        {
            var data = await _mediator.Send(request);
            return Ok(data);
        }

    }
}
