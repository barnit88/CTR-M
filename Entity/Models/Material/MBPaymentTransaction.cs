using System;

namespace Entity.Models.Material
{
    public class MBPaymentTransaction : AuditModel
    {

        public int MaterialBoughtId { get; set; }

        public MaterialBought MaterialBought { get; set; }

        public double Payment { get; set; }

        public string PaymentMethod { get; set; }

        public string PaymentType { get; set; }

        public DateTime PaymentDate { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }

    }
}
