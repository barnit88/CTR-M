using Entity.Models.RentedVehicle;
using Repository.Service.Base;
using Repository.Service.IService.IRentedVehicleService;

namespace Repository.Service.Services.RentedVehicleService
{
    public class RVIPaymentTransactionService : BaseService<RVIPaymentTransaction>, IRVIPaymentTransactionService
    {
        private readonly ConstructionDbContext dbContext;

        public RVIPaymentTransactionService(ConstructionDbContext dbContext):base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
