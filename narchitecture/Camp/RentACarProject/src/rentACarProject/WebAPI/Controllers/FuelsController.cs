using Application.Features.Fuels.Commands.Create;
using Application.Features.Fuels.Commands.Delete;
using Application.Features.Fuels.Commands.Update;
using Application.Features.Fuels.Queries.GetById;
using Application.Features.Fuels.Queries.GetList;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FuelsController : BaseController
{
    [HttpPost]
    public async Task<ActionResult<CreatedFuelResponse>> Add([FromBody] CreateFuelCommand command)
    {
        CreatedFuelResponse response = await Mediator.Send(command);

        return CreatedAtAction(nameof(GetById), new { response.Id }, response);
    }

    [HttpPut]
    public async Task<ActionResult<UpdatedFuelResponse>> Update([FromBody] UpdateFuelCommand command)
    {
        UpdatedFuelResponse response = await Mediator.Send(command);

        return Ok(response);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<DeletedFuelResponse>> Delete([FromRoute] Guid id)
    {
        DeleteFuelCommand command = new() { Id = id };

        DeletedFuelResponse response = await Mediator.Send(command);

        return Ok(response);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<GetByIdFuelResponse>> GetById([FromRoute] Guid id)
    {
        GetByIdFuelQuery query = new() { Id = id };

        GetByIdFuelResponse response = await Mediator.Send(query);

        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetListFuelQuery>> GetList([FromQuery] PageRequest pageRequest)
    {
        GetListFuelQuery query = new() { PageRequest = pageRequest };

        GetListResponse<GetListFuelListItemDto> response = await Mediator.Send(query);

        return Ok(response);
    }
}