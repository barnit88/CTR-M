using Entity.Models.Labour;
using Repository.Service.Base;
using Repository.Service.IService.ILabourService;

namespace Repository.Service.Services.LabourService
{
    public class LabourService : BaseService<Labour> , ILabourService
    {
        private readonly ConstructionDbContext _DbContext;

        public LabourService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
