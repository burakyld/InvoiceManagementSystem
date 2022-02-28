using IMS.Domain.Entities.Commons;

namespace IMS.Domain.Entities.Contacts
{
    public class Person : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalIdentificationNumber { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string VehicleInformation { get; set; }

    }
}
