using System;

namespace Entity.Models.Employees
{
    public class EmployeePayment : AuditModel
    {

        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public double PaymentRate { get; set; }

        public double Period { get; set; }

        public double Payment { get; set; }

        public string UDF1 { get; set; }
        
        public string UDF2 { get; set; }


    }
}
