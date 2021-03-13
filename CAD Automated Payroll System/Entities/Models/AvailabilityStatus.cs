using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CAD_Automated_Payroll_System.Entities.Models
{
    public class AvailabilityStatus
    {
        [Column("AvailabilityId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Availability Status is required.")]
        public string Status { get; set; }
    }
}
