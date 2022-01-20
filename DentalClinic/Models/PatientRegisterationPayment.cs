using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Models
{
    public partial class PatientRegisterationPayment
    {
        public int PatientRegisterationPaymentId { get; set; }
        public decimal? DrugTotal { get; set; }
        public decimal? FeeTotal { get; set; }
        [Required(ErrorMessage ="Received amount can not be null")]
        public decimal? Payed { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }
        public int? PatientRegisterationCheckId { get; set; }
        public string Description { get; set; }

        public virtual PatientRegisterationCheck PatientRegisterationCheck { get; set; }
    }
}
