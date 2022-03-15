using System;

namespace Entity.Models.Employees
{
    public class Employee : AuditModel
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string State { get; set; }

        public string District { get; set; }

        public string Muncipality { get; set; }

        public string ContactNo { get; set; }

        public string Email { get; set; }

        public string IdentityType { get; set; }

        public string IdentityNo { get; set; }

        public string EmployeeType { get; set; }

        public string EmployeePaymentType { get; set; }

        public bool isActive { get; set; }

        public DateTime DateofBirth { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }


    }
}
