using Entity.Models.Material;
using Repository.Service.Base;
using Repository.Service.IService.IMaterialService;

namespace Repository.Service.Services.MaterialService
{
    public class MSPaymentTransactionService : BaseService<MSPaymentTransaction> , IMSPaymentTransactionService
    {
        private readonly ConstructionDbContext _DbContext;

        public MSPaymentTransactionService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
