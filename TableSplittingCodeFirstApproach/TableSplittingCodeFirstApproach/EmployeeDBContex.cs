using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;


namespace TableSplittingCodeFirstApproach
{
    public class EmployeeDBContex : DbContext
    {

        
        public DbSet<Employee> Employees { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasKey(pk => pk.EmployeeID).ToTable("Employees");

            modelBuilder.Entity<EmployeeContactDetails>()
                .HasKey(pk => pk.EmployeeID).ToTable("Employees");

            modelBuilder.Entity<Employee>()
                .HasRequired(p => p.employeeContactDetails)
                .WithRequiredPrincipal(c => c.employee);

            base.OnModelCreating(modelBuilder);
        }
    }
}