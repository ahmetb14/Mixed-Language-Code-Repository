using NArchitecture.Core.Application.Responses;

namespace Application.Features.Fuels.Commands.Update;

public class UpdatedFuelResponse : IResponse
{
    public Guid Id { get; set; }
}