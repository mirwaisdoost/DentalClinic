using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Models
{
    public partial class HistoryElement
    {
        public HistoryElement()
        {
            PatientHistory = new HashSet<PatientHistory>();
        }

        public int HistoryElementId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int? ApplyToGender { get; set; }

        public virtual Gender ApplyToGenderNavigation { get; set; }
        public virtual ICollection<PatientHistory> PatientHistory { get; set; }
    }
}
