using DentalClinic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalClinic.ViewModels
{
    public class PatientViewModel:Patient
    {
        public string GenderName { get; set; }
    }
}
