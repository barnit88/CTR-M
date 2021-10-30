using Entity.Models.Material;
using Repository.Service.Base;
using Repository.Service.IService.IMaterialService;

namespace Repository.Service.Services.MaterialService
{
    public class MaterialStockService : BaseService<MaterialStock> , IMaterialStockService
    {
        private readonly ConstructionDbContext _DbContext;

        public MaterialStockService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
