using Entity.Models.Contract;
using Repository.Service.Base;
using Repository.Service.IService.IContractService;

namespace Repository.Service.Services.ContractService
{
    public class GiveContractService : BaseService<GiveContract> , IGiveContractService
    {

        private readonly ConstructionDbContext _DbContext;

        public GiveContractService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }

    }
}
