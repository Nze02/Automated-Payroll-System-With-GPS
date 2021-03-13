using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CAD_Automated_Payroll_System.Entities.Models
{
    public class Department
    {
        [Column("DepartmentId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Department is required.")]
        [MaxLength(20, ErrorMessage = "Department name must be 20 characters or less")]
        public string DepartmentName { get; set; }
    }
}
