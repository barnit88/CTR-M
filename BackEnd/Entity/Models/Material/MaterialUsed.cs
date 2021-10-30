using Entity.Models.Sites;

namespace Entity.Models.Material
{
    public class MaterialUsed : AuditModel
    {

        public int MaterialId { get; set; }

        public Material Material { get; set; }

        public int SiteId { get; set; }

        public Site Site { get; set; }

        public string Quantity { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }

    }
}
