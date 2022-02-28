using IMS.Application.Contracts.Persistence.Repositories.Buildings;
using IMS.Domain.Entities.Buildings;
using IMS.Infrastructure.Contracts.Persistence.Repositories.Commons;

namespace IMS.Infrastructure.Contracts.Persistence.Repositories.Buildings
{
    public class BlockRepository : RepositoryBase<Block>, IBlockRepository
    {
        public BlockRepository(ApplicationContext dbContext) : base(dbContext)
        {

        }
    }
}
