using NArchitecture.Core.Application.Responses;

namespace Application.Features.Fuels.Queries.GetById;

public class GetByIdFuelResponse : IResponse
{
    public Guid Id { get; set; }
}