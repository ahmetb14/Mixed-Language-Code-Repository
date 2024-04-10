using Application.Features.Models.Commands.Create;
using Application.Features.Models.Commands.Delete;
using Application.Features.Models.Commands.Update;
using Application.Features.Models.Queries.GetById;
using Application.Features.Models.Queries.GetList;
using AutoMapper;
using NArchitecture.Core.Application.Responses;
using Domain.Entities;
using NArchitecture.Core.Persistence.Paging;

namespace Application.Features.Models.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CreateModelCommand, Model>();
        CreateMap<Model, CreatedModelResponse>();

        CreateMap<UpdateModelCommand, Model>();
        CreateMap<Model, UpdatedModelResponse>();

        CreateMap<DeleteModelCommand, Model>();
        CreateMap<Model, DeletedModelResponse>();

        CreateMap<Model, GetByIdModelResponse>();

        CreateMap<Model, GetListModelListItemDto>();
        CreateMap<IPaginate<Model>, GetListResponse<GetListModelListItemDto>>();
    }
}