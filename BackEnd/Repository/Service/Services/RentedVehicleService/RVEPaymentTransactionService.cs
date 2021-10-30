using Entity.Models.RentedVehicle;
using Repository.Service.Base;
using Repository.Service.IService.IRentedVehicleService;

namespace Repository.Service.Services.RentedVehicleService
{
    public class RVEPaymentTransactionService : BaseService<RVEPaymentTransaction> , IRVEPaymentTransactionService
    {
        private readonly ConstructionDbContext dbContext;

        public RVEPaymentTransactionService(ConstructionDbContext dbContext):base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
