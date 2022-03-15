using Entity.Models.PersonalVehicle;
using Repository.Service.Base;
using Repository.Service.IService.IPersonalVehicleService;

namespace Repository.Service.Services.PersonalVehicleService
{
    public class PVIPaymentTransactionService : BaseService<PVIPaymentTransaction> , IPVIPaymentTransactionService
    {
        private readonly ConstructionDbContext _DbContext;

        public PVIPaymentTransactionService(ConstructionDbContext DbContext):base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
