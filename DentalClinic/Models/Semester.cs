using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Models
{
    public partial class Semester
    {
        public Semester()
        {
            StudentSessionGroupDoctor = new HashSet<StudentSessionGroupDoctor>();
        }

        public int SemesterId { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<StudentSessionGroupDoctor> StudentSessionGroupDoctor { get; set; }
    }
}
