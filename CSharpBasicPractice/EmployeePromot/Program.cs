using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePromot
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> objEmp = new List<Employee>();
            objEmp.Add(new Employee() { Id=101 , Name = "Torikul", Experiance = 6, Salary="70000"});
            objEmp.Add(new Employee() { Id=102 , Name = "Shorif", Experiance = 3, Salary="40000"});
            Employee.PromoteEmployee(objEmp);

        }

        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Salary { get; set; }
            public int Experiance { get; set; }

            public static void PromoteEmployee(List<Employee> empList )
            {
                foreach (Employee emp in empList)
                {
                    if (emp.Experiance > 5)
                    {
                        Console.WriteLine(emp.Name + " "+ "Promoted.");
                    }
                }
            }
        }
    }
}
