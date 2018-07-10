using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    //public delegate void HellFunctionDelegates(string Msg);   
    public delegate void FullNameDelehate(string name, int id);

    class Program
    {
        static void Main(string[] args)
        {
            //HellFunctionDelegates objDel = new HellFunctionDelegates(Print);
            //objDel("Call From Delegates.");

            Program objP = new Program();
            FullNameDelehate objFulNameDel = new FullNameDelehate(objP.PrintFullName);
            objFulNameDel("Torikul", 101);
        }

        public void PrintFullName(string Name, int Id)
        {
            Console.WriteLine("Name = {0} && Id = {1}", Name, Id);
        }

        
        //public static void Print(string Message)
        //{
        //    Console.WriteLine(Message);
        //}
    }
}
