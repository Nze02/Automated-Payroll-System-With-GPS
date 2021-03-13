using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CAD_Automated_Payroll_System.Entities.Models
{
    public class OnlineStatus
    {
        [Column("OnlineStatusID")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Online status is required.")]
        public string Status { get; set; }
    }
}
