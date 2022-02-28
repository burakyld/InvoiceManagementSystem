using AutoMapper;
using IMS.Application.Features.Commands.Buildings.AddApartment;
using IMS.Domain.Entities.Buildings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Apartment, AddApartmentCommand>().ReverseMap();
            CreateMap<AddApartmentCommand, Apartment>().ReverseMap();
        }

    }
}
