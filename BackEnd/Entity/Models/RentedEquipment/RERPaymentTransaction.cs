using System;

namespace Entity.Models.RentedEquipment
{
    public class RERPaymentTransaction : AuditModel
    {

        public int RERentId { get; set; }

        public RERent RERent { get; set; }

        public string PaymentType { get; set; }

        public string PaymentMethod { get; set; }

        public double Payment { get; set; }

        public DateTime PaymentDate { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }

    }
}
