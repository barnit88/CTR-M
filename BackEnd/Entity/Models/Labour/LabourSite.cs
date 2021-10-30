using Entity.Models.Sites;
using System;

namespace Entity.Models.Labour
{
    public class LabourSite : AuditModel
    {
        public int LabourId { get; set; }

        public Labour Labour { get; set; }

        public string LabourType { get; set; }

        public string LabourPaymentType { get; set; }

        public int SiteId { get; set; }

        public Site Site { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }

    }
}
