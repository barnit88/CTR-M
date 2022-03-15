using Entity.Models.PersonalEquipment;
using Repository.Service.Base;
using Repository.Service.IService.IPersonalEquipmentService;

namespace Repository.Service.Services.PersonalEquipmentService
{
    public class PEIPaymentTransactionService : BaseService<PEIPaymentTransaction>, IPEIPaymentTransactionService
    {
        private readonly ConstructionDbContext _DbContext;

        public PEIPaymentTransactionService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
