using Entity.Models.Vendors;
using System;

namespace Entity.Models.PersonalVehicle
{
    public class PVBought : AuditModel
    {

        public int PersonalVehicleId { get; set; }

        public PersonalVehicle PersonalVehicle { get; set; }

        public int VendorId { get; set; }

        public Vendor Vendor { get; set; }

        public double BoughtPrice { get; set; }

        public DateTime BoughtDate { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }


    }
}
