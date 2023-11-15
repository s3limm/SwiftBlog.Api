using MediatR;
using Microsoft.AspNetCore.Mvc;
using SwiftBlog.Api.Core.Application.Features.CQRS.Commands.Category.Create;
using SwiftBlog.Api.Core.Application.Features.CQRS.Commands.Category.Delete;
using SwiftBlog.Api.Core.Application.Features.CQRS.Commands.Category.Update;
using SwiftBlog.Api.Core.Application.Features.CQRS.Queries.Category.GetCategory;
using SwiftBlog.Api.Core.Application.Features.CQRS.Queries.Category.List;

namespace SwiftBlog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("List")]
        public async Task<IActionResult> GetAllList()
        {
           var list =  await _mediator.Send(new GetAllCategoryListQueryRequest());
            return Ok(list);
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _mediator.Send(new GetCategoryByIdQueryRequest(id));
            return Ok(category);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateCategoryCommandRequest request)
        {
            await _mediator.Send(request);
            return Created("", request.Name);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateCategoryCommandRequest request)
        {
            var data = await _mediator.Send(request);
            return Ok(data);
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(DeleteCategoryCommandRequest request)
        {
            var data = await _mediator.Send(request);
            return Ok(data);
        }
    }
}
