using IMS.Application.Contracts.Persistence.Repositories.Buildings;
using IMS.Domain.Entities.Buildings;
using IMS.Infrastructure.Contracts.Persistence.Repositories.Commons;

namespace IMS.Infrastructure.Contracts.Persistence.Repositories.Buildings
{
    public class ApartmentTypeRepository : RepositoryBase<ApartmentType>, IApartmentTypeRepository
    {
        public ApartmentTypeRepository(ApplicationContext dbContext) : base(dbContext)
        {

        }
    }
}
