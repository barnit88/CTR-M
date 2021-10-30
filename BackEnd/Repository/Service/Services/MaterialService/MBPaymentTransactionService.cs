using Entity.Models.Material;
using Repository.Service.Base;
using Repository.Service.IService.IMaterialService;

namespace Repository.Service.Services.MaterialService
{
    public class MBPaymentTransactionService : BaseService<MBPaymentTransaction> , IMBPaymentTransactionService
    {
        private readonly ConstructionDbContext _DbContext;

        public MBPaymentTransactionService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
