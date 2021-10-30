using Entity.Models.Contract;
using Repository.Service.Base;
using Repository.Service.IService.IContractService;

namespace Repository.Service.Services.ContractService
{
    public class GCPaymentTransactionService : BaseService<GCPaymentTransaction> , IGCPaymentTransactionService
    {
        private readonly ConstructionDbContext dbContext;

        public GCPaymentTransactionService(ConstructionDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

    }
}
