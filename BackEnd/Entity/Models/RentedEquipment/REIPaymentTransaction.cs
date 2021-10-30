using System;

namespace Entity.Models.RentedEquipment
{
    public class REIPaymentTransaction : AuditModel
    {

        public int REIncomeId { get; set; }

        public REIncome REIncome { get; set; }

        public string PaymentMethod { get; set; }

        public string PaymentType { get; set; }

        public double Payment { get; set; }

        public DateTime PaymentDate { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }

    }
}
