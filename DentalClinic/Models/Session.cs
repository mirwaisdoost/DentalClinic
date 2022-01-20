using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Models
{
    public partial class Session
    {
        public Session()
        {
            StudentSessionGroupDoctor = new HashSet<StudentSessionGroupDoctor>();
        }

        public int SessionId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public byte? Status { get; set; }

        public virtual ICollection<StudentSessionGroupDoctor> StudentSessionGroupDoctor { get; set; }
    }
}
