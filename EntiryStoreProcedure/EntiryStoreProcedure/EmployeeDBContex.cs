using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EntiryStoreProcedure
{
    public class EmployeeDBContex : DbContext
    {
        public DbSet<Employee> Employees { set; get;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Employee>().MapToStoredProcedures(); // This section will create Store Procedure...
            base.OnModelCreating(modelBuilder);
        }
    }
}