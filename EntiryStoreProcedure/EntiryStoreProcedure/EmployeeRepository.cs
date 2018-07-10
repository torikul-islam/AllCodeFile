using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntiryStoreProcedure
{
    public class EmployeeRepository 
    {
        EmployeeDBContex employeeDBContex = new EmployeeDBContex();
        public List<Employee> GetEmployees()
        {
           return employeeDBContex.Employees.ToList();
        }

        public void InsertEmployee(Employee employee)
        {
            employeeDBContex.Employees.Add(employee);
            employeeDBContex.SaveChanges();
        }
        public void UpdateEmployee(Employee employee)
        {
            Employee UpdateToEmployee = employeeDBContex.Employees.FirstOrDefault(x => x.ID == employee.ID);
            UpdateToEmployee.Name = employee.Name;
            UpdateToEmployee.Salary = employee.Salary;
            UpdateToEmployee.Gender = employee.Gender;
            employeeDBContex.SaveChanges();
        }
        public void DeleteEmployee(Employee employee)
        {
            Employee DeleteToEmployee = employeeDBContex.Employees.FirstOrDefault(x => x.ID == employee.ID);
            employeeDBContex.Employees.Remove(DeleteToEmployee);
            employeeDBContex.SaveChanges();
        }
    }
}