using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHidingOverriding
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am Base Class Method.");
        }
    }
    public class ChildClass : BaseClass
    {
        // override keyword hides the base class method.
        
        public override void Print()
        {
            Console.WriteLine("I am Child Class Method.");
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            BaseClass bc = new ChildClass();
            bc.Print();


            Console.ReadKey();
        }
    }
}
