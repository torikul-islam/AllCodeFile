using System;


namespace OutParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            double mul;
            Program p = new Program();
            p.Calculate(10, 20, out sum, out mul);
            Console.WriteLine("Sum = {0} && Mul = {1}", sum, mul );

        }

        // when you want a method return more than one value this time we use out parameter
        
        public void Calculate(int Fn ,int Sn, out int sum, out double Mul)
        {
            sum = Fn + Sn;
            Mul = Fn * Sn;
        } 
    }
}
