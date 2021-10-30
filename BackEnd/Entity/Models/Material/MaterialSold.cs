using Entity.Models.Clients;
using Entity.Models.Sites;
using System;

namespace Entity.Models.Material
{
    public class MaterialSold : AuditModel
    {

        public int MaterialId { get; set; }

        public Material Material { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }

        public int SiteId { get; set; }

        public Site Site { get; set; }

        public string Quantity { get; set; }

        public double Rate { get; set; }
        
        public double TotalPrice { get; set; }

        public DateTime SoldDate { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }

    }
}
