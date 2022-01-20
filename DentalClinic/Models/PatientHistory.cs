using System;
using System.Collections.Generic;

namespace DentalClinic.Models
{
    public partial class PatientHistory
    {
        public int PatientHistoryId { get; set; }
        public int? PatientRegisterationId { get; set; }
        public int? HistoryElementId { get; set; }

        public virtual HistoryElement HistoryElement { get; set; }
        public virtual PatientRegisteration PatientRegisteration { get; set; }
    }
}
