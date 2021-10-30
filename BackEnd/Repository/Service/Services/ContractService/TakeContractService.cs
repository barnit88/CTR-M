using Entity.Models.Contract;
using Repository.Service.Base;
using Repository.Service.IService.IContractService;

namespace Repository.Service.Services.ContractService
{
    public class TakeContractService : BaseService<TakeContract> , ITakeContractService 
    {

        private readonly ConstructionDbContext _DbContext;

        public TakeContractService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }

    }
}
