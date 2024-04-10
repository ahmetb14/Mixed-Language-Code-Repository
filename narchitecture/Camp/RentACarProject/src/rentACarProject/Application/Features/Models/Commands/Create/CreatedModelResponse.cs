using NArchitecture.Core.Application.Responses;

namespace Application.Features.Models.Commands.Create;

public class CreatedModelResponse : IResponse
{
    public Guid Id { get; set; }
    public Guid BrandId { get; set; }
    public string Name { get; set; }
    public decimal DailyPrice { get; set; }
    public string ImageUrl { get; set; }
}