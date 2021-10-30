using Entity.Models.PersonalEquipment;
using Repository.Service.Base;
using Repository.Service.IService.IPersonalEquipmentService;

namespace Repository.Service.Services.PersonalEquipmentService
{
    public class PEBoughtService : BaseService<PEBought> , IPEBoughtService
    {
        private readonly ConstructionDbContext _DbContext;

        public PEBoughtService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
