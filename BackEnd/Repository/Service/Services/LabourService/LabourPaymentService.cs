using Entity.Models.Labour;
using Repository.Service.Base;
using Repository.Service.IService.ILabourService;

namespace Repository.Service.Services.LabourService
{
    public class LabourPaymentService : BaseService<LabourPayment> , ILabourPaymentService
    {
        private readonly ConstructionDbContext _DbContext;

        public LabourPaymentService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
