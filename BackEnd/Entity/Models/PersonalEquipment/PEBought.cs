using Entity.Models.Vendors;
using System;

namespace Entity.Models.PersonalEquipment
{
    public class PEBought : AuditModel
    {

        public int PersonalEquipmentId { get; set; }

        public PersonalEquipment PersonalEquipment { get; set; }

        public int VendorId { get; set; }

        public Vendor Vendor { get; set; }

        public double BoughtPrice { get; set; }

        public DateTime BoughtDate { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }

    }
}
