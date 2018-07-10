using System;
using System.Text;


namespace stringBuilderr
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("1st Append ");
            stringBuilder.Append("2nd Append ");
            stringBuilder.Append("3rd Append ");
            stringBuilder.Append("4th Append ");
            stringBuilder.Append("5th Append ");
            Console.WriteLine(stringBuilder.ToString());
            Console.ReadLine();
        }
    }
}
