using Application.Features.Brands.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Commands.Update;

public class UpdateBrandCommand : IRequest<UpdatedBrandResponse>
{
    public Guid Id { get; set; }
    public required string Name { get; set; }

    public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommand, UpdatedBrandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBrandRepository _brandRepository;
        private readonly BrandBusinessRules _brandBusinessRules;

        public UpdateBrandCommandHandler(IMapper mapper, IBrandRepository brandRepository,
                                         BrandBusinessRules brandBusinessRules)
        {
            _mapper = mapper;
            _brandRepository = brandRepository;
            _brandBusinessRules = brandBusinessRules;
        }

        public async Task<UpdatedBrandResponse> Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
        {
            Brand? brand = await _brandRepository.GetAsync(predicate: b => b.Id == request.Id, cancellationToken: cancellationToken);
            await _brandBusinessRules.BrandShouldExistWhenSelected(brand);
            brand = _mapper.Map(request, brand);

            await _brandRepository.UpdateAsync(brand!);

            UpdatedBrandResponse response = _mapper.Map<UpdatedBrandResponse>(brand);
            return response;
        }
    }
}