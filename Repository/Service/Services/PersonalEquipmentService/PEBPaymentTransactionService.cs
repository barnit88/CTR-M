using Entity.Models.PersonalEquipment;
using Repository.Service.Base;
using Repository.Service.IService.IPersonalEquipmentService;

namespace Repository.Service.Services.PersonalEquipmentService
{
    public class PEBPaymentTransactionService : BaseService<PEBPaymentTransaction> , IPEBPaymentTransactionService
    {
        private readonly ConstructionDbContext _DbContext;

        public PEBPaymentTransactionService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }

    }
}
