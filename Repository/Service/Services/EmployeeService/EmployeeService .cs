using Entity.Models.Employees;
using Repository.Service.Base;
using Repository.Service.IService.IEmployeeService;

namespace Repository.Service.Services.EmployeeService
{
    public class EmployeeService : BaseService<Employee> , IEmployeeService
    {
        private readonly ConstructionDbContext _DbContext;

        public EmployeeService(ConstructionDbContext DbContext) : base(DbContext)
        {
            _DbContext = DbContext;
        }
    }
}
