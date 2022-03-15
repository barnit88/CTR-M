using Entity.Models.Vendors;
using Repository.Service.Base;
using Repository.Service.IService.IVendorService;

namespace Repository.Service.Services.VendorService
{
    public class VendorService : BaseService<Vendor> , IVendorService
    {
        private readonly ConstructionDbContext dbContext;

        public VendorService(ConstructionDbContext dbContext):base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
