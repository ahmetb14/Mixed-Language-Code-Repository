using Application.Features.Fuels.Rules;
using Application.Services.Repositories;
using NArchitecture.Core.Persistence.Paging;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Services.Fuels;

public class FuelManager : IFuelService
{
    private readonly IFuelRepository _fuelRepository;
    private readonly FuelBusinessRules _fuelBusinessRules;

    public FuelManager(IFuelRepository fuelRepository, FuelBusinessRules fuelBusinessRules)
    {
        _fuelRepository = fuelRepository;
        _fuelBusinessRules = fuelBusinessRules;
    }

    public async Task<Fuel?> GetAsync(
        Expression<Func<Fuel, bool>> predicate,
        Func<IQueryable<Fuel>, IIncludableQueryable<Fuel, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        Fuel? fuel = await _fuelRepository.GetAsync(predicate, include, withDeleted, enableTracking, cancellationToken);
        return fuel;
    }

    public async Task<IPaginate<Fuel>?> GetListAsync(
        Expression<Func<Fuel, bool>>? predicate = null,
        Func<IQueryable<Fuel>, IOrderedQueryable<Fuel>>? orderBy = null,
        Func<IQueryable<Fuel>, IIncludableQueryable<Fuel, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    )
    {
        IPaginate<Fuel> fuelList = await _fuelRepository.GetListAsync(
            predicate,
            orderBy,
            include,
            index,
            size,
            withDeleted,
            enableTracking,
            cancellationToken
        );
        return fuelList;
    }

    public async Task<Fuel> AddAsync(Fuel fuel)
    {
        Fuel addedFuel = await _fuelRepository.AddAsync(fuel);

        return addedFuel;
    }

    public async Task<Fuel> UpdateAsync(Fuel fuel)
    {
        Fuel updatedFuel = await _fuelRepository.UpdateAsync(fuel);

        return updatedFuel;
    }

    public async Task<Fuel> DeleteAsync(Fuel fuel, bool permanent = false)
    {
        Fuel deletedFuel = await _fuelRepository.DeleteAsync(fuel);

        return deletedFuel;
    }
}
