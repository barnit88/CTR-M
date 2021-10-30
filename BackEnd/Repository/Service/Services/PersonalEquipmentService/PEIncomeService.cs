using Entity.Models.PersonalEquipment;
using Repository.Service.Base;
using Repository.Service.IService.IPersonalEquipmentService;

namespace Repository.Service.Services.PersonalEquipmentService
{
    public class PEIncomeService : BaseService<PEIncome> , IPEIncomeService
    {
        private readonly ConstructionDbContext _DbContext;

        public PEIncomeService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
