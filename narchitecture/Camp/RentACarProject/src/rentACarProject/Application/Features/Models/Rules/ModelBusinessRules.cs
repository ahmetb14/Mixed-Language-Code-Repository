using Application.Features.Models.Constants;
using Application.Services.Repositories;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using NArchitecture.Core.Localization.Abstraction;
using Domain.Entities;

namespace Application.Features.Models.Rules;

public class ModelBusinessRules : BaseBusinessRules
{
    private readonly IModelRepository _modelRepository;
    private readonly ILocalizationService _localizationService;

    public ModelBusinessRules(IModelRepository modelRepository, ILocalizationService localizationService)
    {
        _modelRepository = modelRepository;
        _localizationService = localizationService;
    }

    private async Task throwBusinessException(string messageKey)
    {
        string message = await _localizationService.GetLocalizedAsync(messageKey, ModelsBusinessMessages.SectionName);
        throw new BusinessException(message);
    }

    public async Task ModelShouldExistWhenSelected(Model? model)
    {
        if (model == null)
            await throwBusinessException(ModelsBusinessMessages.ModelNotExists);
    }

    public async Task ModelIdShouldExistWhenSelected(Guid id, CancellationToken cancellationToken)
    {
        Model? model = await _modelRepository.GetAsync(
            predicate: m => m.Id == id,
            enableTracking: false,
            cancellationToken: cancellationToken
        );
        await ModelShouldExistWhenSelected(model);
    }
}