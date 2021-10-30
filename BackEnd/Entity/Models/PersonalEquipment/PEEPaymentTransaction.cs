using System;

namespace Entity.Models.PersonalEquipment
{
    public class PEEPaymentTransaction : AuditModel
    {
        public int PEExpensesId { get; set; }

        public PEExpenses PEExpenses { get; set; }

        public double Payment { get; set; }

        public string PaymentMethod { get; set; }

        public string PaymentType { get; set; }

        public DateTime PaymentDate { get; set; }

        public string UDF1 { get; set; }

        public string UDF2 { get; set; }


    }
}
