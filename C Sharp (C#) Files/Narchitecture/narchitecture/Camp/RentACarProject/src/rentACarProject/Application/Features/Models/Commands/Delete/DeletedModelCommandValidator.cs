using FluentValidation;

namespace Application.Features.Models.Commands.Delete;

public class DeleteModelCommandValidator : AbstractValidator<DeleteModelCommand>
{
    public DeleteModelCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
    }
}