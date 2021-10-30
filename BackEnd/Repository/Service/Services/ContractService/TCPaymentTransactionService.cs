using Entity.Models.Contract;
using Repository.Service.Base;
using Repository.Service.IService.IContractService;

namespace Repository.Service.Services.ContractService
{
    public class TCPaymentTransactionService : BaseService<TCPaymentTransaction> , ITCPaymentTransactionService
    {
        private readonly ConstructionDbContext _DbContext;

        public TCPaymentTransactionService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
