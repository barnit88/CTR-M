using System;

namespace Entity.Models.Material
{
    public class MSPaymentTransaction : AuditModel
    {

        public int MaterialSoldId { get; set; }

        public MaterialSold MaterialSold { get; set; }

        public double Payment { get; set; }

        public string PaymentMethod { get; set; }

        public string PaymentType { get; set; }

        public DateTime PaymentDate { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }

    }
}
