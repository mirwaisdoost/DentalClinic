using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Models
{
    public partial class Student
    {
        public Student()
        {
            StudentSessionGroupDoctor = new HashSet<StudentSessionGroupDoctor>();
        }

        public int StudentId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string FatherName { get; set; }
        [Required]
        public string LastName { get; set; }
        [RegularExpression(@"^\(?([0-9]{4})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})[-. ]?([0-9]{3})$",
                   ErrorMessage = "Entered phone format is not valid.")]
        [Required]
        public string Phone { get; set; }

        public virtual ICollection<StudentSessionGroupDoctor> StudentSessionGroupDoctor { get; set; }
        public virtual ICollection<PatientRegisterationCheck> PatientRegisterationCheck { get; set; }
    }
}
