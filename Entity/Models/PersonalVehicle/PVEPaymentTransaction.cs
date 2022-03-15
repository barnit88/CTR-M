using System;

namespace Entity.Models.PersonalVehicle
{
    public class PVEPaymentTransaction : AuditModel
    {
        public int PVExpensesId { get; set; }

        public PVExpenses PVExpenses { get; set; }

        public string PaymentType { get; set; }
        
        public string PaymentMethod { get; set; }

        public double Payment { get; set; }

        public DateTime PaymentDate { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }

    }
}
