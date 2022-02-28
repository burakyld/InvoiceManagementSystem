using IMS.Application.Contracts.Persistence.Repositories.Payments;
using IMS.Domain.Entities.Payments;
using IMS.Infrastructure.Contracts.Persistence.Repositories.Commons;

namespace IMS.Infrastructure.Contracts.Persistence.Repositories.Invoices
{
    public class PaymentRepository : RepositoryBase<Payment>, IPaymentRepository
    {
        public PaymentRepository(ApplicationContext dbContext) : base(dbContext)
        {

        }
    }
}
