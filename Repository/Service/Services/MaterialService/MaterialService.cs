using Entity.Models.Material;
using Repository.Service.Base;
using Repository.Service.IService.IMaterialService;

namespace Repository.Service.Services.MaterialService
{
    public class MaterialService : BaseService<Material> , IMaterialService
    {
        private readonly ConstructionDbContext _DbContext;

        public MaterialService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
