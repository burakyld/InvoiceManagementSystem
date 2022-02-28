using IMS.Domain.Entities.Buildings;
using MediatR;

namespace IMS.Application.Features.Commands.Buildings.AddApartment
{
    public class AddApartmentCommand
    {
        public int Number { get; set; }
        public bool IsFull { get; set; }
        public ApartmentType ApartmentType { get; set; }
        public Block Block { get; set; }
        public int FloorNumber { get; set; }
    }
}
