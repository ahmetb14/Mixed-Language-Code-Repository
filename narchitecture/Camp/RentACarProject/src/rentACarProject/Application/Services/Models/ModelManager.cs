using Application.Features.Models.Rules;
using Application.Services.Repositories;
using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.Models;

public class ModelManager : IModelService
{
    private readonly IModelRepository _modelRepository;
    private readonly ModelBusinessRules _modelBusinessRules;

    public ModelManager(IModelRepository modelRepository, ModelBusinessRules modelBusinessRules)
    {
        _modelRepository = modelRepository;
        _modelBusinessRules = modelBusinessRules;
    }

    public async Task<Model?> GetAsync(
        Expression<Func<Model, bool>> predicate,
        Func<IQueryable<Model>, IIncludableQueryable<Model, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        Model? model = await _modelRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return model;
    }

    public async Task<IPaginate<Model>?> GetListAsync(
        Expression<Func<Model, bool>>? predicate = null,
        Func<IQueryable<Model>, IOrderedQueryable<Model>>? orderBy = null,
        Func<IQueryable<Model>, IIncludableQueryable<Model, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<Model> modelList = await _modelRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return modelList;
    }

    public async Task<Model> AddAsync(Model model)
    {
        Model addedModel = await _modelRepository.AddAsync(model);

        return addedModel;
    }

    public async Task<Model> UpdateAsync(Model model)
    {
        Model updatedModel = await _modelRepository.UpdateAsync(model);

        return updatedModel;
    }

    public async Task<Model> DeleteAsync(Model model, bool permanent = false)
    {
        Model deletedModel = await _modelRepository.DeleteAsync(model);

        return deletedModel;
    }
}
