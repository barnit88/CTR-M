namespace Entity.Models.RentedEquipment
{
    public class RentedEquipment : AuditModel
    {

        public string EquipmentName { get; set; }

        public string BrandName { get; set; }
        
        public string ModelName { get; set; }

        public string Type { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }

    }
}
