using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models.PersonalEquipment
{
    public class PersonalEquipment : AuditModel
    {

        public string EquipmentName { get; set; }

        public string BrandName { get; set; }

        public string ModelName { get; set; }

        public DateTime BoughtDate { get; set; }

        public string EquipmentType { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }


    }
}
