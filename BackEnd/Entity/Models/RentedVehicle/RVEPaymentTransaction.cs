using System;

namespace Entity.Models.RentedVehicle
{
    public class RVEPaymentTransaction : AuditModel
    {
        public int RVExpensesId { get; set; }

        public RVExpenses RVExpenses { get; set; }

        public string PaymentType { get; set; }

        public string PaymentMethod { get; set; }

        public double Payment { get; set; }

        public DateTime PaymentDate { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }


    }
}
