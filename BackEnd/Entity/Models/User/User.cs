using Microsoft.AspNetCore.Identity;
using Entity.Models.Employees;

namespace Entity.Models.Users
{
    public class User : IdentityUser
    {

#nullable enable
        public int? EmployeeId { get; set; }

        public Employee? Employee { get; set; }
#nullable disable
    }
}
