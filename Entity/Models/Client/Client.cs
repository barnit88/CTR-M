namespace Entity.Models.Clients
{
    public class Client : AuditModel
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string State { get; set; }

        public string District { get; set; }

        public string Muncipality { get; set; }

        public string ContactNo { get; set; }

        public string Email { get; set; }

        public string IdentityType { get; set; }

        public string IdentityNo { get; set; }

        public string ClientType { get; set; }

        public string ClientCompanyName { get; set; }

        public string ClientCompanyContactNumber { get; set; }

        public string ClientCompanyIdentityType { get; set; }

        public string ClientCompanyIdentityNumber { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }

    }
}
