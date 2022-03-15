using Entity.Models.RentedEquipment;
using Repository.Service.Base;
using Repository.Service.IService.IRentedEquipmentService;

namespace Repository.Service.Services.RentedEquipmentService
{
    public class REIPaymentTransactionService : BaseService<REIPaymentTransaction> , IREIPaymentTransactionService
    {
        private readonly ConstructionDbContext dbContext;

        public REIPaymentTransactionService(ConstructionDbContext dbContext):base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
