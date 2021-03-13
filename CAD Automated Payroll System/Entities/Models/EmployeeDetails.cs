using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CAD_Automated_Payroll_System.Entities.Models
{
    public class EmployeeDetails
    {
        [Column("EmpId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }

        public string Image { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        public Guid DepartmentId { get; set; }

        [ForeignKey(nameof(OnlineStatus))]
        public Guid OnlineStatusID { get; set; }

    }
}
