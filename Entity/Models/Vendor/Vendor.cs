namespace Entity.Models.Vendors
{
    public class Vendor : AuditModel
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string State { get; set; }

        public string District { get; set; }

        public string Muncipality { get; set; }

        public string ContactNumber { get; set; }

        public string Email { get; set; }

        public string IdentityType { get; set; }

        public string IdentityNo { get; set; }

        public string VendorType { get; set; }

        public string CompanyName { get; set; }

        public string CompanyContactNo { get; set; }

        public string CompanyIdentityType { get; set; }

        public string CompanyIdentityNumber { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }

    }
}
