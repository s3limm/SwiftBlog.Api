using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SwiftBlog.Api.Core.Application.Features.CQRS.Commands.Blog.Create;
using SwiftBlog.Api.Core.Application.Features.CQRS.Commands.Blog.Delete;
using SwiftBlog.Api.Core.Application.Features.CQRS.Commands.Blog.Update;
using SwiftBlog.Api.Core.Application.Features.CQRS.Queries.Blog.GetAllBlogListRequest;
using SwiftBlog.Api.Core.Application.Features.CQRS.Queries.Blog.GetById;
using System.Linq.Expressions;
using System.Security.Cryptography.Xml;

namespace SwiftBlog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BlogController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("list")]

        public async Task<IActionResult> GetBlogList()
        {
            var data = _mediator.Send(new GetAllBlogListQueryRequest());
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlogById(int id)
        {
            var data = _mediator.Send(new GetBlogByIdQueryRequest(id));
            return Ok(data);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateBlog(CreateBlogCommandRequest request)
        {
            var data = _mediator.Send(request);
            return Created("",request.Title);
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommandRequest request)
        {
            var data = await _mediator.Send(request);
            return Ok(data);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteBlog(DeleteBlogCommandRequest request)
        {
            var data = await _mediator.Send(request);
            return Ok(data);
        }
    }
}
