using System;

namespace Entity.Models.RentedVehicle
{
    public class RVRPaymentTransaction : AuditModel
    {
        public int RVRentId { get; set; }

        public RVRent RVRent { get; set; }

        public string PaymentType { get; set; }

        public string PaymentMethod { get; set; }

        public double Payment { get; set; }

        public DateTime PaymentDate { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }

    }
}
