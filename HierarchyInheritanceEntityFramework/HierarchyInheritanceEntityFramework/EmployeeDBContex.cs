using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HierarchyInheritanceEntityFramework
{
    public class EmployeeDBContex : DbContext
    {
        public DbSet<Employee> EmployeesFromDbSET { get; set; }

       
    }
}