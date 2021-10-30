using Entity.Models.RentedEquipment;
using Repository.Service.Base;
using Repository.Service.IService.IRentedEquipmentService;

namespace Repository.Service.Services.RentedEquipmentService
{
    public class REEPaymentTransactionService : BaseService<REEPaymentTransaction> , IREEPaymentTransactionService
    {
        private readonly ConstructionDbContext _DbContext;

        public REEPaymentTransactionService(ConstructionDbContext DbContext) :base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
