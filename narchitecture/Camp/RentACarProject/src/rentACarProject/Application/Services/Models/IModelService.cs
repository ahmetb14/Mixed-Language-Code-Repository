using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.Models;

public interface IModelService
{
    Task<Model?> GetAsync(
        Expression<Func<Model, bool>> predicate,
        Func<IQueryable<Model>, IIncludableQueryable<Model, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<Model>?> GetListAsync(
        Expression<Func<Model, bool>>? predicate = null,
        Func<IQueryable<Model>, IOrderedQueryable<Model>>? orderBy = null,
        Func<IQueryable<Model>, IIncludableQueryable<Model, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<Model> AddAsync(Model model);
    Task<Model> UpdateAsync(Model model);
    Task<Model> DeleteAsync(Model model, bool permanent = false);
}
