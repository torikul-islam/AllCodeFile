using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortComplexType
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 101,
                Name = "Jessan",
                Salary = 5000
            };
            Customer customer2 = new Customer()
            {
                Id = 102,
                Name = "Rayet",
                Salary = 6000
            };
            Customer customer3 = new Customer()
            {
                Id = 103,
                Name = "Shahed",
                Salary = 4000
            };

            List<Customer> listCustomer = new List<Customer>();
            listCustomer.Add(customer1);
            listCustomer.Add(customer2);
            listCustomer.Add(customer3);

            

            listCustomer.Sort();
            foreach (Customer c in listCustomer)
            {
                Console.WriteLine(c.Name);
            }

            Console.WriteLine("------------------------");
            listCustomer.Reverse();
            foreach (Customer c in listCustomer)
            {
                Console.WriteLine(c.Name);
            }


            GetByName gbn = new GetByName();
            listCustomer.Sort(gbn);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Sort Using Own Class");
            foreach (Customer custitem in listCustomer)
            {
                Console.WriteLine(custitem.Name);
            }

            


            Console.ReadKey();
        }
    }

    public class GetByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
             return x.Name.CompareTo(y.Name);
        }
    }
    public class Customer : IComparable<Customer>
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Salary { get; set; }

        public int CompareTo(Customer other)
        {
            //if (this.Salary > other.Salary)
            //    return 1;
            //else if (this.Salary < other.Salary)
            //    return -1;
            //else
            //{
            //    return 0;
            //}


            // All code implement in one line...

            // compare Based on Salary.....
            //int result =  this.Salary.CompareTo(other.Salary);
            //return result;

            // Compare Based On Name......

           return this.Name.CompareTo(other.Name);
        }
    }
}
