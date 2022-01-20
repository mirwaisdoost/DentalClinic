using DentalClinic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DentalClinic.ViewModels
{
    public class PatientRegistrationViewModel
    {
        public int patientRegistrationID { get; set; }
        public int? CheckId { get; set; }
        public DateTime? registerDate { get; set; }
        public int? patientID { get; set; }
        public int? PatientAge { get; set; }
        public string patientName { get; set; }
        public string patientLastName { get; set; }
        public string patientPhone { get; set; }
        public int? studentid { get; set; }
        public string studentname { get; set; }
        public DateTime? patientDateofBirth { get; set; }
        public string patientGender { get; set; }
        public string patientJob { get; set; }
        public int? doctorID { get; set; }
        public string doctorName { get; set; }
        public string doctorLastName { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd-MMM-yyyy}")]
        [DataType(DataType.Date)]
        public decimal? registrationFee { get; set; }
        public List<int?> historyElementID { get; set; }
        public List<string> historyElementName { get; set; }
        public List<int?> teethNumberId { get; set; }
        public List<int?> teethNumber { get; set; }
        public List<string> teethLeftOrRight { get; set; }
        public List<string> note { get; set; }
        public List<string> teethTopOrButtom { get; set; }
        public List<string> teethAduOrChd { get; set; }
        public List<int?> patientRegistrationCheckID { get; set; }
        public List<decimal?> drugFeeTotal { get; set; }
        public List<decimal?> otherFeesTotal { get; set; }
        public List<decimal?> drugFee { get; set; }
        public List<decimal?> otherFees { get; set; }
        public List<decimal?> CheckTotalPayment { get; set; }
        [DataType(DataType.Date)]
        public List<DateTime?> patientRegistrationCheckDate { get; set; }
        public List<string> doctornotelist { get; set; }
        public DateTime? patientCheckDate { get; set; }
        public string doctornote { get; set; }
        public List<int?> patientRegistrationPaymentID { get; set; }
        public List<int?> patientRegistrationPaymentCheckID { get; set; }
        [DataType(DataType.Date)]
        public List<DateTime?> patientRegistrationPaymentDate { get; set; }
        public int? paymentID { get; set; }
        public DateTime? paymentDate { get; set; }
        public decimal? paymentDrugFee { get; set; }
        public decimal? paymentOtherFee { get; set; }
        public decimal? paymentPaidAmount { get; set; }
        public string paymentDescription { get; set; }
        public List<decimal?> paidAmount { get; set; }
        public List<int?> drugID { get; set; }
        public List<string> drugName { get; set; }
        public List<int?> quantity { get; set; }
        public List<decimal?> drugBasePrice { get; set; }
        public List<decimal?> drugTotalPrice { get; set; }
        public List<int?> feeId { get; set; }
        public List<string> feeName { get; set; }
        public List<decimal?> feeBasePrice { get; set; }
        public List<decimal?> feeTotalPrice { get; set; }
    }
}
