using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCentralBank
{
    public static class EuroCentralBank
    {
        
        public static int ApplySpread(Paese paese)
        {
            try
            {
                paese = (EuroZoneCountry)paese;
                Random rnd = new Random();
                return rnd.Next();

            }
            catch 
            {
                return 0;
            }
        }

        
        //private List<Paese> eurozoneCountries;

        //private static readonly Random random = new Random();

        //public EuroCentralBank()
        //{
        //    eurozoneCountries = new List<Paese>();
        //}

        //public void AddEurozoneCountry(Paese country)
        //{
        //    if (!country.IsEurozoneMember)
        //    {
        //        throw new ArgumentException($"{country.Name} non è un membro dell'Eurozona.");
        //    }

        //    eurozoneCountries.Add(country);
        //}

        //public  double GenerateRandomSpread(double minValue, double maxValue)
        //{
        //    return random.NextDouble() * (maxValue - minValue) + minValue;
        //}

        //public double CalculateFakeSpread()
        //{
        //    // Calcolo di uno spread fittizio
        //    // In questo esempio, si utilizza un valore fisso, ma puoi implementare una logica più complessa.
        //    return 2.5;
        //}
    }
}
