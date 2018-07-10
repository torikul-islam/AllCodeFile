using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryOverList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Country country1 = new Country() { Code = "BD", Name = "BANGLADESH", Capital = "DHAKA" };
            //Country country2 = new Country() { Code = "IND", Name = "INDIA", Capital = "DELHI" };
            //Country country3 = new Country() { Code = "AUS", Name = "AUSTRALIA", Capital = "CANBERRA" };


            List<Country> listCountry = new List<Country>() // directly Add to listCountry Using Object Initilizer.
            {
                 new Country { Code = "BD", Name = "BANGLADESH", Capital = "DHAKA" },
                 new Country { Code = "IND", Name = "INDIA", Capital = "DELHI" },
                 new Country { Code = "AUS", Name = "AUSTRALIA", Capital = "CANBERRA" }
            };

            //listCountry.Add(country1);
            //listCountry.Add(country2);
            //listCountry.Add(country3);

            Console.WriteLine("Enter Country Code");
            string countryCode = Console.ReadLine().ToUpper();
            Country ResultCountry = listCountry.Find(country => country.Code == countryCode);

            if(ResultCountry == null)
            {
                Console.WriteLine("Code Not found.");
            }
            else
            {
                Console.WriteLine("Name = {0} , Capital = {1}", ResultCountry.Name, ResultCountry.Capital);
            }

        }
    }

    public class Country
    {
        public String Name { get; set; }
        public String Code { get; set; }
        public String Capital { get; set; }
    }
}
