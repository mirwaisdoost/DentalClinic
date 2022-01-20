using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Models
{
    public partial class TeethNumber
    {
        public TeethNumber()
        {
            PatientTeeth = new HashSet<PatientTeeth>();
        }

        public int TeethNumberId { get; set; }
        [Required]
        public int? Number { get; set; }
        [Required]
        public string LeftOrRight { get; set; }
        [Required]
        public string TopOrButtom { get; set; }
        [Required]
        public string AduOrChd { get; set; }

        public virtual ICollection<PatientTeeth> PatientTeeth { get; set; }
    }
}
