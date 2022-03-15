using Entity.Models.RentedVehicle;
using Repository.Service.Base;
using Repository.Service.IService.IRentedVehicleService;

namespace Repository.Service.Services.RentedVehicleService
{
    public class RVRPaymentTransactionService : BaseService<RVRPaymentTransaction>, IRVRPaymentTransactionService
    {
        private readonly ConstructionDbContext dbContext;

        public RVRPaymentTransactionService(ConstructionDbContext dbContext):base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
