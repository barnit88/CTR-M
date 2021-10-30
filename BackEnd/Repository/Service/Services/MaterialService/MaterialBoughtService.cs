using Entity.Models.Material;
using Repository.Service.Base;
using Repository.Service.IService.IMaterialService;

namespace Repository.Service.Services.MaterialService
{
    public class MaterialBoughtService : BaseService<MaterialBought> , IMaterialBoughtService
    {
        private readonly ConstructionDbContext _DbContext;

        public MaterialBoughtService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
