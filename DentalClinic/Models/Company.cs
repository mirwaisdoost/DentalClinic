using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Models
{
    public partial class Company
    {
        public Company()
        {
            DrugElement = new HashSet<DrugElement>();
        }

        public int CompanyId { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<DrugElement> DrugElement { get; set; }
    }
}
