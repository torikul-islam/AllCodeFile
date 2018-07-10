using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDelegates
{
    public delegate void MyDelegates();
    class Program
    {
        static void Main(string[] args)
        {
            Program objP = new Program();
            MyDelegates objDelegate = new MyDelegates(objP.MethodOne); // pointing To Method.
            objDelegate += objP.MethodTwo;
            objDelegate += objP.MethodThree;
            objDelegate();
        }
        public void MethodOne()
        {
            Console.WriteLine("Mehtod One Invoked.");
        }
        public void MethodTwo()
        {
            Console.WriteLine("Mehtod Two Invoked.");
        }
        public void MethodThree()
        {
            Console.WriteLine("Mehtod Three Invoked.");
        }
    }
}
