using Entity.Models.Material;
using Repository.Service.Base;
using Repository.Service.IService.IMaterialService;

namespace Repository.Service.Services.MaterialService
{
    public class MaterialSoldService : BaseService<MaterialSold> , IMaterialSoldService
    {
        private readonly ConstructionDbContext _DbContext;

        public MaterialSoldService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
