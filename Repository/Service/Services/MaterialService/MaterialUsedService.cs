using Entity.Models.Material;
using Repository.Service.Base;
using Repository.Service.IService.IMaterialService;

namespace Repository.Service.Services.MaterialService
{
    public class MaterialUsedService : BaseService<MaterialUsed> , IMaterialUsedService
    {
        private readonly ConstructionDbContext _DbContext;

        public MaterialUsedService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
