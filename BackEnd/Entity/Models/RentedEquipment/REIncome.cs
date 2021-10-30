using Entity.Models.Clients;
using System;

namespace Entity.Models.RentedEquipment
{
    public class REIncome : AuditModel
    {

        public int RentedEquipmentId { get; set; }

        public RentedEquipment RentedEquipment { get; set; }

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
