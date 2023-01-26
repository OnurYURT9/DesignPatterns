using System;

namespace ConsoleApp.Singleton
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var countries = await CountryProvider.Instance.GetCountries();
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            foreach(var country in countries)
            {
                Console.WriteLine(country.Name);
            }
            var countryprovider1 = new CountryProvider();
            var countries1 = await CountryProvider.Instance.GetCountries();
            Console.WriteLine(DateTime.Now.ToLongTimeString());
        }
    }
}


