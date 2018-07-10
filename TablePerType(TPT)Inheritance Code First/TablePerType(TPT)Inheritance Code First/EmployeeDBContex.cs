using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TablePerType_TPT_Inheritance_Code_First
{
    public class EmployeeDBContex  : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

    }
}