using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Models
{
    public partial class Patient
    {
        public Patient()
        {
            PatientRegisteration = new HashSet<PatientRegisteration>();
        }

        public int PatientId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int? GenderId { get; set; }
        [Required]
        public DateTime? DataOfBrith { get; set; }
        public string Job { get; set; }
        public string Address { get; set; }
        [Required]
        [RegularExpression("([0-9]{10})",
                   ErrorMessage = "Entered phone format is not valid.")]
        public string Phone { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual ICollection<PatientRegisteration> PatientRegisteration { get; set; }
    }
}
