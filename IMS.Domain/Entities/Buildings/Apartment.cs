using IMS.Domain.Entities.Commons;
using IMS.Domain.Entities.Contacts;

namespace IMS.Domain.Entities.Buildings
{
    public class Apartment : EntityBase
    {
        public int Number { get; set; }
        public bool IsFull { get; set; }
        public ApartmentType ApartmentType { get; set; }
        public Block Block { get; set; }
        public int FloorNumber { get; set; }
        public Person Person { get; set; }

    }
}
