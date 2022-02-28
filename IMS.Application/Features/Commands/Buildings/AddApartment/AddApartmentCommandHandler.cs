using AutoMapper;
using IMS.Application.Contracts.Persistence.Repositories.Buildings;
using IMS.Domain.Entities.Buildings;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IMS.Application.Features.Commands.Buildings.AddApartment
{
    public class AddApartmentCommandHandler
    {
        private readonly IApartmentRepository _apartmentRepository;
        private readonly IMapper _mapper;

        public AddApartmentCommandHandler(IApartmentRepository apartmentRepository, IMapper mapper)
        {
            _mapper = mapper;
            _apartmentRepository = apartmentRepository;
        }

        public async Task<Apartment> Handle(AddApartmentCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<Apartment>(request);
            
            return await _apartmentRepository.AddAsync(entity);
        }
    }
}
