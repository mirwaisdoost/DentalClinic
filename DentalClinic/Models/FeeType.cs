using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DentalClinic.Models
{
    public partial class FeeType
    {
        public FeeType()
        {
            FeeElement = new HashSet<FeeElement>();
        }

        public int FeeTypeId { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<FeeElement> FeeElement { get; set; }
    }
}
