using Entity.Models.PersonalEquipment;
using Repository.Service.Base;
using Repository.Service.IService.IPersonalEquipmentService;

namespace Repository.Service.Services.PersonalEquipmentService
{
    public class PEEPaymentTransactionService : BaseService<PEEPaymentTransaction> , IPEEPaymentTransactionService
    {
        private readonly ConstructionDbContext _DbContext;

        public PEEPaymentTransactionService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
