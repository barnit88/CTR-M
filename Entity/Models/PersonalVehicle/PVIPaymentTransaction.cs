using System;

namespace Entity.Models.PersonalVehicle
{
    public class PVIPaymentTransaction : AuditModel
    {
        public int PVIncomeID { get; set; }

        public PVIncome PVIncome { get; set; }

        public string PaymentType { get; set; }

        public string PaymentMethod { get; set; }

        public double Payment { get; set; }
        
        public DateTime PaymentDate { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }

    }
}
