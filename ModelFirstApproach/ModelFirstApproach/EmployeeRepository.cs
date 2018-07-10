using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelFirstApproach
{
    public class EmployeeRepository 
    {
        public List<Department> GetDepartments()
        {
            EmployeeBDContex employeeBDContex = new EmployeeBDContex();
            return employeeBDContex.Departments.Include("Employees").ToList();
        }
    }
}