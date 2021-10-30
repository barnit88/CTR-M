using Entity.Models.PersonalVehicle;
using Repository.Service.Base;
using Repository.Service.IService.IPersonalVehicleService;

namespace Repository.Service.Services.PersonalVehicleService
{
    public class PVBoughtService : BaseService<PVBought>, IPVBoughtService
    {
        private readonly ConstructionDbContext _DbContext;

        public PVBoughtService(ConstructionDbContext DbContext):base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
