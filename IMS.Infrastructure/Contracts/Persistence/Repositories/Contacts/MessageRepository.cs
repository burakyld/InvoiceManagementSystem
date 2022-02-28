using IMS.Application.Contracts.Persistence.Repositories.Contacts;
using IMS.Domain.Entities.Contacts;
using IMS.Infrastructure.Contracts.Persistence.Repositories.Commons;

namespace IMS.Infrastructure.Contracts.Persistence.Repositories.Buildings
{
    public class MessageRepository : RepositoryBase<Message>, IMessageRepository
    {
        public MessageRepository(ApplicationContext dbContext) : base(dbContext)
        {

        }
    }
}
