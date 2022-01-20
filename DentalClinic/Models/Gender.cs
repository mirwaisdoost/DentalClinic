using System;
using System.Collections.Generic;

namespace DentalClinic.Models
{
    public partial class Gender
    {
        public Gender()
        {
            HistoryElement = new HashSet<HistoryElement>();
            Patient = new HashSet<Patient>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<HistoryElement> HistoryElement { get; set; }
        public virtual ICollection<Patient> Patient { get; set; }
    }
}
