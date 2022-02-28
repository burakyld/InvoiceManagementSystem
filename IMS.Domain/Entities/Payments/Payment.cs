using IMS.Domain.Entities.Commons;
using IMS.Domain.Entities.Contacts;
using System;

namespace IMS.Domain.Entities.Payments
{
    public class Payment : EntityBase
    {
        public string PaymentNumber { get; set; }
        public int Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public Person Person { get; set; }
    }
}
