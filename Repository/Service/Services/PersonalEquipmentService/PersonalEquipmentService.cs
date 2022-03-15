using Entity.Models.PersonalEquipment;
using Repository.Service.Base;
using Repository.Service.IService.IPersonalEquipmentService;

namespace Repository.Service.Services.PersonalEquipmentService
{
    public class PersonalEquipmentService : BaseService<PersonalEquipment> , IPersonalEquipmentService
    {
        private readonly ConstructionDbContext _DbContext;

        public PersonalEquipmentService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
