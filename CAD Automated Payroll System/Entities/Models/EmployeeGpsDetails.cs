using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CAD_Automated_Payroll_System.Entities.Models
{
    public class EmployeeGpsDetails
    {
        [Column("GpsId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Employee Id is required.")]
        public Guid EmpId { get; set; }

        [Required(ErrorMessage = "Date and Time are required.")]
        public DateTime Date_Time { get; set; }

        [Required(ErrorMessage = "Longitude Id is required.")]
        public string Longitude { get; set; }

        [Required(ErrorMessage = "Latitude Id is required.")]
        public string Latitude { get; set; }
    }
}
