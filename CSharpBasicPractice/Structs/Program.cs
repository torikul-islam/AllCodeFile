using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{

    public struct Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

         // Some of the key points regarding the Constructor are:
            // 1. A class can have any number of constructors.
            // 2. A constructor doesn't have any return type, not even void.
            // 3. A static constructor can not be a parametrized constructor.
            // 4. Within a class you can create only one static constructor.
        public Customer(int id, string name) // Create constructor.......
        {
            this.ID = id;
            this.Name = name;
        }

        public void Print()
        {
            Console.WriteLine("Id = {0} && Name = {1}", ID, Name);
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            // pass value using object
            Customer c1 = new Customer();
            c1.ID = 101;
            c1.Name = "Peter";
            c1.Print();

            //pass value to constructor
            Customer c2 = new Customer(102, "Marry");
            c2.Print();


            // pass value using object initializer ... in C# 3.0 
            Customer c3 = new Customer
            {
                ID = 103,
                Name = "Mark"
            };
            c3.Print();
            
        }
    }
}
