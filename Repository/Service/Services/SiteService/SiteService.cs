using Entity.Models.Sites;
using Repository.Service.Base;
using Repository.Service.IService.ISiteService;

namespace Repository.Service.Services.SiteService
{
    public class SiteService : BaseService<Site> , ISiteService 
    {
        private readonly ConstructionDbContext dbContext;

        public SiteService(ConstructionDbContext dbContext):base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
