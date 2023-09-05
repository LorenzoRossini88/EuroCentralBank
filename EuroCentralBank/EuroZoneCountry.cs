using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCentralBank
{
    public class EuroZoneCountry : EUZone, IEuroZone
    {
        public double Spread;
        public double Debit;
        public string Coin;
        
        
        public void ApplyEuro()
        {
            Coin = "Euro";
        }

        public EuroZoneCountry(string name) : base(name)
        {

            ApplyEuro();
            this.Name = name;
            
        }


    }
}
