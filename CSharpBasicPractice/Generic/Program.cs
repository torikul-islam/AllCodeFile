using System;


namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
           bool IsEqual = Calculator.AreEqual<String>("Ab", "ab");

            if(IsEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            Console.ReadLine();
        }
        

    }

    public class Calculator
    {
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }
}
