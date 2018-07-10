using System;


namespace Swap
{
    class Program
    {
        static void Swap<T>(ref T a , ref T b) // Swap uisng Generics And Ref Keyword
        {
            T TempValue; 
            TempValue = a;
            a = b;
            b = TempValue;
        }



        static void Main(string[] args)
        {
            int a = 40, b = 60;
            Console.WriteLine("Before Swap: a = {0} b = {1}", a, b);

            Swap<int>(ref a, ref b); // Swap uisng Generics And Ref Keyword
            Console.WriteLine("After Swap: a = {0} b = {1}", a, b);
            Console.ReadLine();

            //SwippingMethod(50, 70);
        }


        //public static void SwippingMethod(int a, int b)
        //{
        //    //Console.WriteLine("Before Swip: a = {0} b = {1}", a, b);

        //    //int z = 0;
        //    //z = a;
        //    //a = b;
        //    //b = z;
        //    //Console.WriteLine("After Swip: a = {0} b = {1}", a , b);
        //}
    }
}
