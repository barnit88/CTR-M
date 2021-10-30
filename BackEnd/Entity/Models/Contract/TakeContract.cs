using Entity.Models.Clients;
using Entity.Models.Sites;
using System;

namespace Entity.Models.Contract
{
    public class TakeContract : AuditModel
    {

        public int ClientId { get; set; }

        public Client Client { get; set; }

        public int SiteId { get; set; }

        public Site Site { get; set; }

        public int ContractFinishPeriod { get; set; }

        public DateTime ContractStartDate { get; set; }

        public DateTime ContractFinishDate { get; set; }

        public double ContractAmount { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }

    }
}
