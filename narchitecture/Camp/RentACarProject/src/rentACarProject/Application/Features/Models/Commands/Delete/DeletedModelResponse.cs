using NArchitecture.Core.Application.Responses;

namespace Application.Features.Models.Commands.Delete;

public class DeletedModelResponse : IResponse
{
    public Guid Id { get; set; }
}