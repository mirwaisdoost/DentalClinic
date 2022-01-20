using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Models
{
    public partial class Doctor
    {
        public Doctor()
        {
            PatientRegisteration = new HashSet<PatientRegisteration>();
            StudentSessionGroupDoctor = new HashSet<StudentSessionGroupDoctor>();
        }

        public int DoctorId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string FatherName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Jop { get; set; }
        public string JobLocation { get; set; }
        [RegularExpression("([0-9]{10})",
                   ErrorMessage = "Entered phone format is not valid.")]
        //[RegularExpression(@"^\(?([0-9]{4})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})[-. ]?([0-9]{3})$",
        //           ErrorMessage = "Entered phone format is not valid.")]
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<PatientRegisteration> PatientRegisteration { get; set; }
        public virtual ICollection<StudentSessionGroupDoctor> StudentSessionGroupDoctor { get; set; }
    }
}
