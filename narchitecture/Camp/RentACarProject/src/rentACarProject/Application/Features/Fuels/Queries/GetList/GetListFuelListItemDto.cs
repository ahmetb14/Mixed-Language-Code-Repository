using NArchitecture.Core.Application.Dtos;

namespace Application.Features.Fuels.Queries.GetList;

public class GetListFuelListItemDto : IDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}

