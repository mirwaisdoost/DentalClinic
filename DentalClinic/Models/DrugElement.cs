using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Models
{
    public partial class DrugElement
    {
        public DrugElement()
        {
            PatientRegisterationCheckDrug = new HashSet<PatientRegisterationCheckDrug>();
        }

        public int DrugElementId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal? Price { get; set; }
        [Required]
        public int? CompanyId { get; set; }
        [Required]
        public int? DrugTypeId { get; set; }

        public virtual Company Company { get; set; }
        public virtual DrugType DrugType { get; set; }
        public virtual ICollection<PatientRegisterationCheckDrug> PatientRegisterationCheckDrug { get; set; }
    }
}
