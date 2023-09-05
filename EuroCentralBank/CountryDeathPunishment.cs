using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCentralBank
{
    public class CountryDeathPunishment : Paese
    {
        public void Death() 
        {
            Console.WriteLine("Ha la pena di morte");
        }

        public CountryDeathPunishment(string name): base(name) 
        { 
        
        }
    }
}
