using FluentValidation;

namespace Application.Features.Fuels.Commands.Delete;

public class DeleteFuelCommandValidator : AbstractValidator<DeleteFuelCommand>
{
    public DeleteFuelCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}