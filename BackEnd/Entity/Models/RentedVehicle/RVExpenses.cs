using Entity.Models.Vendors;
using System;

namespace Entity.Models.RentedVehicle
{
    public class RVExpenses : AuditModel
    {
        public int RentedVehicleId { get; set; }

        public RentedVehicle RentedVehicle { get; set; }
        
        public int VendorId { get; set; }

        public Vendor Vendor { get; set; }
        
        public string ExpensesType { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public double Expenses { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }

    }
}
