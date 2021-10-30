using System;

namespace Entity.Models.Contract
{
    public class ExtendGiveContract : AuditModel
    {   
        public int GiveContractId { get; set; }

        public GiveContract GiveContract { get; set; }

        public int AdditionalPeriod { get; set; }

        public DateTime DateFrom { get; set; }

        public DateTime ToDate { get; set; }

        public double AdditionalBudget { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }


    }
}
