using Entity.Models.Sites;
using Entity.Models.Vendors;
using System;

namespace Entity.Models.Material
{
    public class MaterialBought : AuditModel
    {
        public int MaterialId { get; set; }

        public Material Material { get; set; }

        public int VendorId { get; set; }

        public Vendor Vendor { get; set; }

        public int SiteId { get; set; }

        public Site Site { get; set; }

        public string Quantity { get; set; }

        public double Rate { get; set; }

        public double TotalPrice { get; set; }

        public DateTime BoughtDate { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }


    }
}
