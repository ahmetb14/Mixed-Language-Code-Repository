using Application.Features.Fuels.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.Fuels.Rules;

public class FuelBusinessRules : BaseBusinessRules
{
    private readonly IFuelRepository _fuelRepository;
    private readonly ILocalizationService _localizationService;

    public FuelBusinessRules(IFuelRepository fuelRepository, ILocalizationService localizationService)
    {
        _fuelRepository = fuelRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, FuelsBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task FuelShouldExistWhenSelected(Fuel? fuel)
    {
        if (fuel == null)
            await throwBusinessException(FuelsBusinessMessages.FuelNotExists);
    }

    public async Task FuelIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        Fuel? fuel = await _fuelRepository.GetAsync(
            predicate: f => f.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await FuelShouldExistWhenSelected(fuel);
    }
}