using IMS.Domain.Entities.Buildings;
using IMS.Domain.Entities.Contacts;
using IMS.Domain.Entities.Invoices;
using IMS.Domain.Entities.Payments;
using Microsoft.EntityFrameworkCore;

namespace IMS.Infrastructure.Contracts.Persistence
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<ApartmentType> ApartmentTypes { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceType> InvoiceTypes { get; set; }
        public DbSet<Payment> Payments { get; set; }
    }
}
