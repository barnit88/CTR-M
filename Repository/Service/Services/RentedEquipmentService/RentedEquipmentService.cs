using Entity.Models.RentedEquipment;
using Repository.Service.Base;
using Repository.Service.IService.IRentedEquipmentService;

namespace Repository.Service.Services.RentedEquipmentService
{
    public class RentedEquipmentService : BaseService<RentedEquipment> , IRentedEquipmentService
    {
        private readonly ConstructionDbContext dbContext;

        public RentedEquipmentService(ConstructionDbContext dbContext):base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
