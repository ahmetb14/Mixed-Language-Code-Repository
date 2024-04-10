using NArchitecture.Core.Application.Responses;

namespace Application.Features.Fuels.Commands.Delete;

public class DeletedFuelResponse : IResponse
{
    public Guid Id { get; set; }
}