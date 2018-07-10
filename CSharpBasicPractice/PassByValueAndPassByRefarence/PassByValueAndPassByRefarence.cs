using System;


namespace PassByValueAndPassByRefarence
{
    class PassByValueAndPassByRefarence
    {
        static void Main(string[] args)
        {
            int j = 0;
           // SampleMethod( j)    //Pass By value parameter.
            SampleMethod( ref j); //Pass By referance parameter( Ref keyword pointing to location.)
          Console.WriteLine(j);
        }

        public static void SampleMethod(ref int j)
        {
            j = 101;
        }
    }
}
