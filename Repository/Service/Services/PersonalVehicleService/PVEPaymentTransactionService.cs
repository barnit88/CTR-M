using Entity.Models.PersonalVehicle;
using Repository.Service.Base;
using Repository.Service.IService.IPersonalVehicleService;

namespace Repository.Service.Services.PersonalVehicleService
{
    public class PVEPaymentTransactionService : BaseService<PVEPaymentTransaction> , IPVEPaymentTransactionService
    {
        private readonly ConstructionDbContext _DbContext;

        public PVEPaymentTransactionService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
