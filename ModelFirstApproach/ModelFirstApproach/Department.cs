using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelFirstApproach
{
    public class Department
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Location { get; set; }
        public List<Employee> Employees { get; set; }
    }
}