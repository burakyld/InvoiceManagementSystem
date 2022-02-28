using IMS.Domain.Entities.Buildings;
using IMS.Domain.Entities.Commons;
using System;

namespace IMS.Domain.Entities.Invoices
{
    public class Invoice : EntityBase
    {
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int Amount { get; set; }
        public Apartment Apartment { get; set; }
        public InvoiceType InvoiceType { get; set; }
    }
}
