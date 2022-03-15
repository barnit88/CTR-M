using Entity.Models.RentedEquipment;
using Repository.Service.Base;
using Repository.Service.IService.IRentedEquipmentService;

namespace Repository.Service.Services.RentedEquipmentService
{
    public class RERentService : BaseService<RERent>, IRERentService
    {
        private readonly ConstructionDbContext dbContext;

        public RERentService(ConstructionDbContext dbContext):base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
