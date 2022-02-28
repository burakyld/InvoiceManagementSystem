using IMS.Application.Contracts.Persistence.Repositories.Invoices;
using IMS.Domain.Entities.Invoices;
using IMS.Infrastructure.Contracts.Persistence.Repositories.Commons;

namespace IMS.Infrastructure.Contracts.Persistence.Repositories.Invoices
{
    public class InvoiceTypeRepository : RepositoryBase<InvoiceType>, IInvoiceTypeRepository
    {
        public InvoiceTypeRepository(ApplicationContext dbContext) : base(dbContext)
        {

        }
    }
}
