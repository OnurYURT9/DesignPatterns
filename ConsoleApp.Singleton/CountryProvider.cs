using ConsoleApp.Singleton.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Singleton
{
   public class CountryProvider
    {
       
      /*  private static CountryProvider instance=null;
        public static CountryProvider Instance
        {
            get 
            {
               
                if(instance is not null)
                {
                    return instance;
                }
                else
                {
                    instance = new CountryProvider();
                    return instance;
                }
                return new CountryProvider();
            }
            set => instance = value;
        }
        private new Task<List<Country>> Countries { get; private set; }
        public async Task<List<Country>> GetCountries()
        {
            if(Countries is null)
            {
                await Task.Delay(2000);

                Countries =  new List<Country>()
                {
                       new Country(){ Name="Türkiye"},
                       new Country(){ Name="Azerbaycan"}
                 };
            }
            return Countries;
        }*/
    }
}