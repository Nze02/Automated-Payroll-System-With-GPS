using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CAD_Automated_Payroll_System.Entities.Models
{
    public class Availability
    {
        [Column("AvailabilityId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Date and Time are required.")]
        public DateTime Date_Time { get; set; }

        public Guid EmpId { get; set; }

        public string Status { get; set; }

        public string Image { get; set; }
    }
}
