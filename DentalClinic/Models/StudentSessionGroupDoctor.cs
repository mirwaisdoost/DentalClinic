using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Models
{
    public partial class StudentSessionGroupDoctor
    {
        public int StudentSessionGroupDoctorId { get; set; }
        [Required]
        public int? SessionId { get; set; }
        public int? StudentId { get; set; }
        [Required]
        public int? GroupId { get; set; }
        [Required(ErrorMessage = "Doctor field is required.")]
        public int? DoctorId { get; set; }
        [Required]
        public int? SemesterId { get; set; }
        [Required(ErrorMessage = "Subject field is required.")]
        public int? SubjectId { get; set; }
        [Required]
        public int? Duration { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual StudentGroup Group { get; set; }
        public virtual Semester Semester { get; set; }
        public virtual Session Session { get; set; }
        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
