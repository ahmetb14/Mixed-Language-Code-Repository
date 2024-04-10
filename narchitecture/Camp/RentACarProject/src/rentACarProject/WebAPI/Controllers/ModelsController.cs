using Application.Features.Models.Commands.Create;
using Application.Features.Models.Commands.Delete;
using Application.Features.Models.Commands.Update;
using Application.Features.Models.Queries.GetById;
using Application.Features.Models.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ModelsController : BaseController
{
    [HttpPost]
    public async Task<ActionResult<CreatedModelResponse>> Add([FromBody] CreateModelCommand command)
    {
        CreatedModelResponse response = await Mediator.Send(command);

        return CreatedAtAction(nameof(GetById), new { response.Id }, response);
    }

    [HttpPut]
    public async Task<ActionResult<UpdatedModelResponse>> Update([FromBody] UpdateModelCommand command)
    {
        UpdatedModelResponse response = await Mediator.Send(command);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<DeletedModelResponse>> Delete([FromRoute] Guid id)
    {
        DeleteModelCommand command = new() { Id = id };

        DeletedModelResponse response = await Mediator.Send(command);

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GetByIdModelResponse>> GetById([FromRoute] Guid id)
    {
        GetByIdModelQuery query = new() { Id = id };

        GetByIdModelResponse response = await Mediator.Send(query);

        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetListModelQuery>> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListModelQuery query = new() { PageRequest = pageRequest };

        GetListResponse<GetListModelListItemDto> response = await Mediator.Send(query);

        return Ok(response);
    }
}