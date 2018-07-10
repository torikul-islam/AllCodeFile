using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesRealExample
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empl = new List<Employee>();
            empl.Add(new Employee() { ID=101, Name="Shorif" , Experiance=6, salary=10000 });
            empl.Add(new Employee() { ID=102, Name="Saddam" , Experiance=3, salary=80000 });
            empl.Add(new Employee() { ID=103, Name="Sagor" , Experiance=10, salary=40000 });
            isPromote objdelpro = new isPromote(Promote);
            Employee.PromoteEmp(empl, objdelpro);
            Console.ReadKey();

        }

        public static bool Promote(Employee emp)
        {
            if (emp.Experiance > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }



    delegate bool isPromote(Employee emp);
    class Employee
    {
       
        public int ID { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }
        public float Experiance { get; set; }

        public static void PromoteEmp(List<Employee> employeeList, isPromote isEligible)
        {
            foreach (Employee emp in employeeList)
            {
                if (isEligible(emp))
                {
                    Console.WriteLine(emp.Name + " "  + "Promoted.");
                }
            }
        }

    }
}
