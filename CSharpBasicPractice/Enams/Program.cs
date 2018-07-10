using System;


namespace Enams
{
    class Program
    {
        static void Main(string[] args)
        {
            // Week Days...........
            //string[] values = Enum.GetNames(typeof(DayofWeek));
            //int total = 0;
            //foreach (string s in values)
            //{
            //    Console.WriteLine(s);
            //    total++;
            //}
            //Console.WriteLine("Total values in enum type is : {0}", total);

            ////Console.WriteLine();
            //int[] n = (int[])Enum.GetValues(typeof(DayofWeek));
            //foreach (int x in n)
            //{
            //    Console.WriteLine(x);
            //}
            //Console.ReadLine();

            Customer[] objcustomer = new Customer[3];

            objcustomer[0] = new Customer
            {
                Name="Mark",
                Gender = Gender.Male
            };
            objcustomer[1] = new Customer
            {
                Name = "Marry",
                Gender = Gender.Female
            };
            objcustomer[2] = new Customer
            {
                Name = "Mk pota",
                Gender = Gender.Unknown
            };

            foreach(Customer c1 in objcustomer)
            {
                Console.WriteLine(c1.Name + " " + GetGender(c1.Gender));
            }

        }
        public static string GetGender(Gender gender)
        {
            switch (gender) { 
                case Gender.Unknown:
                    return "Unknown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid Gender Detected.";
            }
        }

        //public enum DayofWeek
        //{
        //    Sunday = 1,
        //    Monday, 
        //    Thuesday,
        //    Wednesday, 
        //    Thursday,
        //    Friday,
        //    Satarday
        //};



        public enum Gender
        {
            Unknown,
            Male,
            Female
        }
        public class Customer
        {
            public String Name { get; set; }
            public Gender Gender { get; set; }
        }
    }
}
