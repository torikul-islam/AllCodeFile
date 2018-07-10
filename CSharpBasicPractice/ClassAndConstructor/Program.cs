using System;


namespace ClassAndConstructor
{
    public class Customer
    {
        String _FirstName;
        String _LasttName;

        public Customer(string FirstName, string LastName)
        {
            this._FirstName = FirstName;
            this._LasttName = LastName;
        }





        //public int CustomerMethod(int fn, int sn)
        //{
        //    int Sum = fn + sn;
        //    return Sum;
        //}



        public void PrintFullName()
        {
            Console.WriteLine("Full Name = {0}", _FirstName + " " + _LasttName);
            
             
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("T","I");
            c1.PrintFullName();
            Console.ReadKey();
        }
    }
}
