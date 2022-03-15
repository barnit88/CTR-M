using Entity.Models.Labour;
using Repository.Service.Base;
using Repository.Service.IService.ILabourService;

namespace Repository.Service.Services.LabourService
{
    public class LabourSiteService : BaseService<LabourSite> , ILabourSiteService
    {
        private readonly ConstructionDbContext _DbContext;

        public LabourSiteService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }

    }
}
