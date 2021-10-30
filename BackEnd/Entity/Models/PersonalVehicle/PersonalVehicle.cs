namespace Entity.Models.PersonalVehicle
{
    public class PersonalVehicle : AuditModel
    {
        public string VehicleName { get; set; }

        public string BrandName { get; set; }

        public string ModelName { get; set; }

        public string NumberPlate { get; set; }

        public string VehicleType { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }


    }
}
