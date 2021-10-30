using Entity.Models.RentedVehicle;
using Repository.Service.Base;
using Repository.Service.IService.IRentedVehicleService;

namespace Repository.Service.Services.RentedVehicleService
{
    public class RentedVehicleService : BaseService<RentedVehicle> ,IRentedVehicleService
    {
        private readonly ConstructionDbContext dbContext;

        public RentedVehicleService(ConstructionDbContext dbContext):base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
