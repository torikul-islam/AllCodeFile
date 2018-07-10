using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCTotorialsPractice.Models
{
    public class EmployeeContex : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}