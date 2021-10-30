using Entity.Models.RentedVehicle;
using Repository.Service.Base;
using Repository.Service.IService.IRentedVehicleService;

namespace Repository.Service.Services.RentedVehicleService
{
    public class RVExpensesService : BaseService<RVExpenses>, IRVExpensesService
    {
        private readonly ConstructionDbContext dbContext;

        public RVExpensesService(ConstructionDbContext dbContext):base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
