using Entity.Models.RentedEquipment;
using Repository.Service.Base;
using Repository.Service.IService.IRentedEquipmentService;

namespace Repository.Service.Services.RentedEquipmentService
{
    public class REIncomeService : BaseService<REIncome> , IREIncomeService
    {
        private readonly ConstructionDbContext dbContext;

        public REIncomeService(ConstructionDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
