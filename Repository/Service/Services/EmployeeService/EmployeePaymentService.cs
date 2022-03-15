using Entity.Models.Employees;
using Repository.Service.Base;
using Repository.Service.IService.IEmployeeService;

namespace Repository.Service.Services.EmployeeService
{
    public class EmployeePaymentService : BaseService<EmployeePayment> , IEmployeePaymentService
    {
        private readonly ConstructionDbContext _DbContext;

        public EmployeePaymentService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
