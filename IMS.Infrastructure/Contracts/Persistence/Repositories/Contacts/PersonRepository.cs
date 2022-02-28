using IMS.Application.Contracts.Persistence.Repositories.Contacts;
using IMS.Domain.Entities.Contacts;
using IMS.Infrastructure.Contracts.Persistence.Repositories.Commons;

namespace IMS.Infrastructure.Contracts.Persistence.Repositories.Buildings
{
    public class PersonRepository : RepositoryBase<Person>, IPersonRepository
    {
        public PersonRepository(ApplicationContext dbContext) : base(dbContext)
        {

        }
    }
}
