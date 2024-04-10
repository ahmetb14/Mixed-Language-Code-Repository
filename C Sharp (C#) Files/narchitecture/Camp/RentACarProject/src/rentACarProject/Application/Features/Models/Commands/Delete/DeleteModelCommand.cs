using Application.Features.Models.Constants;
using Application.Features.Models.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Models.Commands.Delete;

public class DeleteModelCommand : IRequest<DeletedModelResponse>
{
    public Guid Id { get; set; }

    public class DeleteModelCommandHandler : IRequestHandler<DeleteModelCommand, DeletedModelResponse>
    {
        private readonly IMapper _mapper;
        private readonly IModelRepository _modelRepository;
        private readonly ModelBusinessRules _modelBusinessRules;

        public DeleteModelCommandHandler(IMapper mapper, IModelRepository modelRepository,
                                         ModelBusinessRules modelBusinessRules)
        {
            _mapper = mapper;
            _modelRepository = modelRepository;
            _modelBusinessRules = modelBusinessRules;
        }

        public async Task<DeletedModelResponse> Handle(DeleteModelCommand request, CancellationToken cancellationToken)
        {
            Model? model = await _modelRepository.GetAsync(predicate: m => m.Id == request.Id, cancellationToken: cancellationToken);
            await _modelBusinessRules.ModelShouldExistWhenSelected(model);

            await _modelRepository.DeleteAsync(model!);

            DeletedModelResponse response = _mapper.Map<DeletedModelResponse>(model);
            return response;
        }
    }
}