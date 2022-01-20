using System;
using System.Collections.Generic;

namespace DentalClinic.Models
{
    public partial class PatientCheckFee
    {
        public int PatientCheckFeeId { get; set; }
        public int? FeeElementId { get; set; }
        public decimal? Fee { get; set; }
        public int? PatientRegisterationCheckId { get; set; }

        public virtual FeeElement FeeElement { get; set; }
        public virtual PatientRegisterationCheck PatientRegisterationCheck { get; set; }
    }
}
