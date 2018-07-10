using System;
using System.Collections.Generic;

namespace ListCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                Id = 101,
                Name = "Jessan",
                Salary=5000
            };
            Customer customer2 = new Customer()
            {
                Id = 102,
                Name = "Rayet",
                Salary = 7200
            };
            Customer customer3 = new Customer()
            {
                Id = 103,
                Name = "Shahed",
                Salary = 4000
            };

            // Create Customer class Arrary list
            Customer[] customerarray = new Customer[2];
            customerarray[0] = customer1;
            customerarray[1] = customer2;
            //if i want to create a new customer in array list it will build successfull but when run will not working.
            //customerarray[3] = customer3;
            //Using Array ....
            Console.WriteLine("Using Array... Item");
            foreach (Customer customeritem in customerarray)
            {
                Console.WriteLine("Id = {0}, Name = {1} , Salary = {2}", customeritem.Id.ToString(), customeritem.Name, customeritem.Salary.ToString());
            }
            Console.WriteLine("-----------------------------------------");

            // Using list Collection 

            List<Customer> listCustomer = new List<Customer>();
            listCustomer.Add(customer1);
            listCustomer.Add(customer2);
            listCustomer.Add(customer3);

            Console.WriteLine("Using List Collections");
            

            foreach (Customer itemCustomer in listCustomer)
            {
                Console.WriteLine("Id= {0}, Name={1}, Salary={2}", itemCustomer.Id.ToString(), itemCustomer.Name, itemCustomer.Salary.ToString());
            }


            Console.ReadKey();
        }
    }

    public class Customer :IComparable<Customer>
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Salary { get; set; }


      

    }
}
