using Entity.Models.PersonalEquipment;
using Repository.Service.Base;
using Repository.Service.IService.IPersonalEquipmentService;

namespace Repository.Service.Services.PersonalEquipmentService
{
    public class PEExpensesService : BaseService<PEExpenses> , IPEExpensesService
    {
        private readonly ConstructionDbContext _DbContext;

        public PEExpensesService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
