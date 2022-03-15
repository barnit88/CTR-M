using Entity.Models.Clients;
using System;

namespace Entity.Models.PersonalVehicle
{
    public class PVIncome : AuditModel
    {

        public int PvId { get; set; }

        public PersonalVehicle PersonalVehicle { get; set; }

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
