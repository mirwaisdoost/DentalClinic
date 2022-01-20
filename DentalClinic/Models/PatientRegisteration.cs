using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace DentalClinic.Models
{
    public partial class PatientRegisteration 
    {
        public PatientRegisteration()
        {
            PatientHistory = new HashSet<PatientHistory>();
            PatientRegisterationCheck = new HashSet<PatientRegisterationCheck>();
            PatientTeeth = new HashSet<PatientTeeth>();
        }

        public int PatientRegisterationId { get; set; }
        [Required]
        public int? PatientId { get; set; }
        [Required]
        public int? DoctorId { get; set; }
        [Required]
        public decimal? RgisterationFee { get; set; }
        [Required]
        [Range(2.00001, int.MaxValue, ErrorMessage = "Please enter a value greater than 2")]
        public int? Age { get; set; }
        [Required]
        public DateTime? Date { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual ICollection<PatientHistory> PatientHistory { get; set; }
        public virtual ICollection<PatientRegisterationCheck> PatientRegisterationCheck { get; set; }
        public virtual ICollection<PatientTeeth> PatientTeeth { get; set; }

       
    }
}
