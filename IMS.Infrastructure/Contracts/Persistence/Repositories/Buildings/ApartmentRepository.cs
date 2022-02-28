using IMS.Application.Contracts.Persistence.Repositories.Buildings;
using IMS.Domain.Entities.Buildings;
using IMS.Infrastructure.Contracts.Persistence.Repositories.Commons;

namespace IMS.Infrastructure.Contracts.Persistence.Repositories.Buildings
{
    public class ApartmentRepository : RepositoryBase<Apartment>, IApartmentRepository
    {
        public ApartmentRepository(ApplicationContext dbContext) : base(dbContext)
        {

        }
    }
}
