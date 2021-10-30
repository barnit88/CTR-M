using Entity.Models.RentedEquipment;
using Repository.Service.Base;
using Repository.Service.IService.IRentedEquipmentService;

namespace Repository.Service.Services.RentedEquipmentService
{
    public class RERPaymentTransactionService : BaseService<RERPaymentTransaction> , IRERPaymentTransactionService
    {
        private readonly ConstructionDbContext dbContext;

        public RERPaymentTransactionService(ConstructionDbContext DbContext):base(DbContext)
        {
            dbContext = DbContext;
        }
    }
}
