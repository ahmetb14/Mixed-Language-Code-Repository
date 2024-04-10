using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.Fuels;

public interface IFuelService
{
    Task<Fuel?> GetAsync(
        Expression<Func<Fuel, bool>> predicate,
        Func<IQueryable<Fuel>, IIncludableQueryable<Fuel, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<IPaginate<Fuel>?> GetListAsync(
        Expression<Func<Fuel, bool>>? predicate = null,
        Func<IQueryable<Fuel>, IOrderedQueryable<Fuel>>? orderBy = null,
        Func<IQueryable<Fuel>, IIncludableQueryable<Fuel, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );
    Task<Fuel> AddAsync(Fuel fuel);
    Task<Fuel> UpdateAsync(Fuel fuel);
    Task<Fuel> DeleteAsync(Fuel fuel, bool permanent = false);
}
