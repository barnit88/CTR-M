using Entity.Models.PersonalVehicle;
using Repository.Service.Base;
using Repository.Service.IService.IPersonalVehicleService;

namespace Repository.Service.Services.PersonalVehicleService
{
    public class PVIncomeService : BaseService<PVIncome> , IPVIncomeService
    {
        private readonly ConstructionDbContext _DbContext;

        public PVIncomeService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
