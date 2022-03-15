using Entity.Models.RentedVehicle;
using Repository.Service.Base;
using Repository.Service.IService.IRentedVehicleService;

namespace Repository.Service.Services.RentedVehicleService
{
    public class RVIncomeService : BaseService<RVIncome> , IRVIncomeService
    {
        private readonly ConstructionDbContext dbContext;

        public RVIncomeService(ConstructionDbContext dbContext):base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
