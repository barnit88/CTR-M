namespace Entity.Models.Sites
{
    public class Site : AuditModel
    {

        public string SiteName { get; set; }

        public string State { get; set; }

        public string District { get; set; }

        public string Muncipality { get; set; }

        public string SiteWorkType { get; set; }

        public string SiteWorkDetail { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }

    }
}
