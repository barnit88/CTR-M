using System;

namespace Entity.Models.Contract
{
    public class GCPaymentTransaction : AuditModel
    {
        public int GiveContractId { get; set; }

        public GiveContract GiveContract { get; set; }

        public string PaymentType { get; set; }

        public string PaymentMethod { get; set; }

        public double Payment { get; set; }

        public DateTime PaymentDate { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }

    }
}
