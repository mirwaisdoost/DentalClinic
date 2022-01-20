using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Models
{
    public partial class Subject
    {
        public Subject()
        {
            StudentSessionGroupDoctor = new HashSet<StudentSessionGroupDoctor>();
        }

        public int SubjectId { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<StudentSessionGroupDoctor> StudentSessionGroupDoctor { get; set; }
    }
}
