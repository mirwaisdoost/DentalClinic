using System;
using System.Collections.Generic;

namespace DentalClinic.Models
{
    public partial class PatientTeeth
    {
        public int PatientTeethId { get; set; }
        public int? PatientRegisterationId { get; set; }
        public int? TeethNumberId { get; set; }
        public string Note { get; set; }
        public virtual PatientRegisteration PatientRegisteration { get; set; }
        public virtual TeethNumber TeethNumber { get; set; }
    }
}
