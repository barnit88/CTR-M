using Entity.Models.PersonalVehicle;
using Repository.Service.Base;
using Repository.Service.IService.IPersonalVehicleService;

namespace Repository.Service.Services.PersonalVehicleService
{
    public class PVBPaymentTransactionService : BaseService<PVBPaymentTransaction> , IPVBPaymentTransactionService
    {
        private readonly ConstructionDbContext _DbContext;

        public PVBPaymentTransactionService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
