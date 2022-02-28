using IMS.Domain.Entities.Commons;
using System;

namespace IMS.Domain.Entities.Contacts
{
    public class Message : EntityBase
    {
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public bool IsRead { get; set; }
        public Person Sender { get; set; }
        public int SenderId { get; set; }
        public Person Receiver { get; set; }
        public int ReceiverId { get; set; }
    }
}
