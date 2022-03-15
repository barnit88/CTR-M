using Entity.Models.PersonalVehicle;
using Repository.Service.Base;
using Repository.Service.IService.IPersonalVehicleService;

namespace Repository.Service.Services.PersonalVehicleService
{
    public class PersonalVehicleService : BaseService<PersonalVehicle> , IPersonalVehicleService
    {
        private readonly ConstructionDbContext _DbContext;

        public PersonalVehicleService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
