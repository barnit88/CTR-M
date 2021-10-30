using System;

namespace Entity.Models.Labour
{
    public class LabourPayment : AuditModel
    {
        public int LabourSiteId { get; set; }

        public LabourSite LabourSite { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public double PaymentRate { get; set; }

        public double Period { get; set; }

        public double Payment { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }

    }
}
