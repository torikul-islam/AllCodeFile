using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortComplexCompareDelegates
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
                Id = 108,
                Name = "Rayet",
                Salary = 6000
            };
            Customer customer3 = new Customer()
            {
                Id = 105,
                Name = "Shahed",
                Salary = 4000
            };


            List<Customer> listCustomer = new List<Customer>();
            listCustomer.Add(customer1);
            listCustomer.Add(customer2);
            listCustomer.Add(customer3);

            //Comparison<Customer> customerComparer = new Comparison<Customer>(CompareCustomer);

            Console.WriteLine("Before Sorting");
            foreach (Customer c in listCustomer)
            {
                Console.WriteLine(c.Id);
            }

            //listCustomer.Sort(customerComparer); // using hard coded
            //listCustomer.Sort(delegate(Customer c1, Customer c2) { return c1.Id.CompareTo(c2.Id); }); // usi delegates in method

            listCustomer.Sort((cust1, cust2) => cust1.Id.CompareTo(cust2.Id));

            Console.WriteLine("After Sorting");
            foreach (Customer c in listCustomer)
            {
                Console.WriteLine(c.Id);
            }

        }
        
        //private static int CompareCustomer(Customer x, Customer y)
        //{
        //   return x.Id.CompareTo(y.Id);
        //}
    }

    public class Customer
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Salary { get; set; }



    }

}
