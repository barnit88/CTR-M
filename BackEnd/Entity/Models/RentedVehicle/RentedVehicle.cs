namespace Entity.Models.RentedVehicle
{
    public class RentedVehicle : AuditModel
    {

        public string VehicleName { get; set; }

        public string BrandName { get; set; }

        public string ModelName { get; set; }

        public string NumberPlate { get; set; }

        public string Type { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }
    
    }
}
