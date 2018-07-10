using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{

    public class Employee
    {
        public string FirstName = "Fn";
        public string LastName = "Fn";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "- Full Time");
        }
    }
    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "- Part Time");
        }
    }
    public class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "- Temporary Time");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Employee[] objEmployee = new Employee[4];
            objEmployee[0] = new Employee();
            objEmployee[1] = new FullTimeEmployee();
            objEmployee[2] = new PartTimeEmployee();
            objEmployee[3] = new TemporaryEmployee();

            foreach (Employee e in objEmployee)
            {
                e.PrintFullName();
            }

            Console.ReadKey();
        }
    }
}
