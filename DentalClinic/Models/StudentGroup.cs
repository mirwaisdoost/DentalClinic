using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Models
{
    public partial class StudentGroup
    {
        public StudentGroup()
        {
            StudentSessionGroupDoctor = new HashSet<StudentSessionGroupDoctor>();
        }

        public int StudentGroupId { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<StudentSessionGroupDoctor> StudentSessionGroupDoctor { get; set; }
    }
}
