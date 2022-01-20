using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Models
{
    public partial class FeeElement
    {
        public FeeElement()
        {
            PatientCheckFee = new HashSet<PatientCheckFee>();
        }

        public int FeeElementId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal? Fee { get; set; }
        [Required]
        public int? FeeTypeId { get; set; }

        public virtual FeeType FeeType { get; set; }
        public virtual ICollection<PatientCheckFee> PatientCheckFee { get; set; }
    }
}
