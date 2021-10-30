using Entity.Models.Contract;
using Repository.Service.Base;
using Repository.Service.IService.IContractService;

namespace Repository.Service.Services.ContractService
{
    public class ExtendTakeContractService : BaseService<ExtendTakeContract>, IExtendTakeContractService
    {

        private readonly ConstructionDbContext _DbContext;

        public ExtendTakeContractService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }

    }
}
