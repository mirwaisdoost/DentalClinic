using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Models
{
    public partial class PatientRegisterationCheck
    {
        public PatientRegisterationCheck()
        {
            PatientCheckFee = new HashSet<PatientCheckFee>();
            PatientRegisterationCheckDrug = new HashSet<PatientRegisterationCheckDrug>();
            PatientRegisterationPayment = new HashSet<PatientRegisterationPayment>();
        }

        public int PatientRegisterationCheckId { get; set; }
        [Required]
        public DateTime? CheckDate { get; set; }
        public string Note { get; set; }
        public int? PatientRegisterationId { get; set; }
        [Required(ErrorMessage ="Stager Can not be null")]
        public int? StudentId { get; set; }

        public virtual PatientRegisteration PatientRegisteration { get; set; }
        public virtual ICollection<PatientCheckFee> PatientCheckFee { get; set; }
        public virtual ICollection<PatientRegisterationCheckDrug> PatientRegisterationCheckDrug { get; set; }
        public virtual ICollection<PatientRegisterationPayment> PatientRegisterationPayment { get; set; }
    }
}
