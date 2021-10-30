using Entity.Models.PersonalVehicle;
using Repository.Service.Base;
using Repository.Service.IService.IPersonalVehicleService;

namespace Repository.Service.Services.PersonalVehicleService
{
    public class PVExpensesService : BaseService<PVExpenses> , IPVExpensesService
    {
        private readonly ConstructionDbContext _DbContext;

        public PVExpensesService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
