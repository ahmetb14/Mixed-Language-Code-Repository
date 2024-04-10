using Application.Features.Fuels.Commands.Create;
using Application.Features.Fuels.Commands.Delete;
using Application.Features.Fuels.Commands.Update;
using Application.Features.Fuels.Queries.GetById;
using Application.Features.Fuels.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.Fuels.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CreateFuelCommand, Fuel>();
        CreateMap<Fuel, CreatedFuelResponse>();

        CreateMap<UpdateFuelCommand, Fuel>();
        CreateMap<Fuel, UpdatedFuelResponse>();

        CreateMap<DeleteFuelCommand, Fuel>();
        CreateMap<Fuel, DeletedFuelResponse>();

        CreateMap<Fuel, GetByIdFuelResponse>();

        CreateMap<Fuel, GetListFuelListItemDto>();
        CreateMap<IPaginate<Fuel>, GetListResponse<GetListFuelListItemDto>>();
    }
}