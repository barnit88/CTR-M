using Entity.Models.Contract;
using Repository.Service.Base;
using Repository.Service.IService.IContractService;

namespace Repository.Service.Services.ContractService
{
    public class ExtendGiveContractService : BaseService<ExtendGiveContract> , IExtendGiveContractService
    {
        private readonly ConstructionDbContext _DbContext;
        
        public ExtendGiveContractService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
