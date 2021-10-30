using Entity.Models.Clients;
using System;

namespace Entity.Models.RentedVehicle
{
    public class RVIncome : AuditModel
    {

        public int RentedVehicleId { get; set; }

        public RentedVehicle RentedVehicle { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }

        public string RateType { get; set; }

        public DateTime FromDate { get; set; }
        
        public DateTime ToDate { get; set; }

        public double Rate { get; set; }

        public double Period { get; set; }

        public double Income { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }

    }
}
