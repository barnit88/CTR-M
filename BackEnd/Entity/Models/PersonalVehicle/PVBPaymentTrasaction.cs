using System;

namespace Entity.Models.PersonalVehicle
{
    public class PVBPaymentTransaction : AuditModel
    {

        public int PVBoughtId { get; set; }

        public PVBought PVBought { get; set; }

        public string PaymentMethod { get; set; }

        public string PaymentType { get; set; }

        public double Payment { get; set; }

        public DateTime PaymentDate { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }


    }
}
