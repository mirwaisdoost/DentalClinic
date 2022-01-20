using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Models
{
    public partial class DrugType
    {
        public DrugType()
        {
            DrugElement = new HashSet<DrugElement>();
        }

        public int DrugTypeId { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<DrugElement> DrugElement { get; set; }
    }
}
