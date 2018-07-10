using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterArray
{
    class Program
    {
        static void Main(string[] args)
        {
            UseParams(20);
        }

        public static void UseParams( params int [] List)
        {
            for (int i = 0; i < List.Length; i++)
            {
                Console.WriteLine(List[i]);
            }
            Console.WriteLine();
        }
    }
}
