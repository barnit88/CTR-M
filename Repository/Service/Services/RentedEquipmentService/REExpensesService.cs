using Entity.Models.RentedEquipment;
using Repository.Service.Base;
using Repository.Service.IService.IRentedEquipmentService;

namespace Repository.Service.Services.RentedEquipmentService
{
    public class REExpensesService : BaseService<REExpenses> , IREExpensesService
    {
        private readonly ConstructionDbContext dbContext;

        public REExpensesService(ConstructionDbContext dbContext):base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
