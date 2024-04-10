using FluentValidation;

namespace Application.Features.Models.Commands.Create;

public class CreateModelCommandValidator : AbstractValidator<CreateModelCommand>
{
    public CreateModelCommandValidator()
    {
        RuleFor(c => c.BrandId).NotEmpty();
        RuleFor(c => c.Name).NotEmpty();
        RuleFor(c => c.DailyPrice).NotEmpty();
        RuleFor(c => c.ImageUrl).NotEmpty();
    }
}