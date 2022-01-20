using System;
using System.Collections.Generic;

namespace DentalClinic.Models
{
    public partial class PatientRegisterationCheckFeeElement
    {
        public int PatientRegisterationCheckFeeElementId { get; set; }
        public int? FeeElementId { get; set; }
        public int? PatientRegisterationCheckId { get; set; }
        public decimal? Fee { get; set; }
    }
}
