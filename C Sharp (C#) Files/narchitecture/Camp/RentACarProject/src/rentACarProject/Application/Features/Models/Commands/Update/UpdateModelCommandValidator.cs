using FluentValidation;

namespace Application.Features.Models.Commands.Update;

public class UpdateModelCommandValidator : AbstractValidator<UpdateModelCommand>
{
    public UpdateModelCommandValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.BrandId).NotEmpty();
        RuleFor(c => c.Name).NotEmpty();
        RuleFor(c => c.DailyPrice).NotEmpty();
        RuleFor(c => c.ImageUrl).NotEmpty();
    }
}