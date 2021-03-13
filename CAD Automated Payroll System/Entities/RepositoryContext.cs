using CAD_Automated_Payroll_System.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAD_Automated_Payroll_System.Entities
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Availability> Availability { get; set;}
        public DbSet<AvailabilityStatus> AvailabilityStatus { get; set;}
        public DbSet<Department> Departments { get; set;}
        public DbSet<EmployeeDetails> EmployeeDetails { get; set;}
        public DbSet<EmployeeGpsDetails> EmployeeGpsDetails { get; set;}
        public DbSet<EmployeeStatus>EmployeeStatus {get; set;}
        public DbSet<OnlineStatus> OnlineStatus { get; set; }
    }
}
