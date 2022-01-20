using System;
using System.Collections.Generic;

namespace DentalClinic.Models
{
    public partial class PatientRegisterationCheckDrug
    {
        public int PatientRegisterationCheckDrugId { get; set; }
        public int? DrugElementId { get; set; }
        public int? PatientRegisterationCheckId { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }

        public virtual DrugElement DrugElement { get; set; }
        public virtual PatientRegisterationCheck PatientRegisterationCheck { get; set; }
    }
}
