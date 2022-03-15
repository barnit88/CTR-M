using Entity.Models.Clients;
using Repository.Service.Base;
using Repository.Service.IService.IClientService;

namespace Repository.Service.Services.ClientService
{
    public class ClientService : BaseService<Client> , IClientService
    {
        private readonly ConstructionDbContext _dbContext;

        public ClientService(ConstructionDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
