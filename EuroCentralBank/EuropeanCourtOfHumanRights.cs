using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCentralBank
{
    public class EuropeanCourtOfHumanRights 
    {
        public void JudgeCountry(Paese paese) 
        {
            try 
            {
                paese = (CountryDeathPunishment)paese;
                Console.WriteLine("Il paese ha la pena di morte");
            } catch (Exception ex) 
            {
                Console.WriteLine("Il paese non ha la pena di morte");
            }
        }

        
        
        
        
        
        
        
        
        
        
        
        
        
        //public string CheckHumanRightsCompliance(Paese country)
        //{
        //    if (country.IsEUMember || country.IsEurozoneMember)
        //    {
        //        if (country.DeathPenalty == PenaDiMorteEnum.Abolished)
        //        {
        //            return $"{country.Name} : rispetta i diritti umani e non prevede la pena di morte.";
        //        }
        //        else if (country.DeathPenalty == PenaDiMorteEnum.Retained)
        //        {
        //            return $"{country.Name} : non rispetta i diritti umani";
        //        }
        //        else
        //        {
        //            return $"{country.Name}: pena di morte non specificata";
        //        }
        //    }
        //    else
        //    {
        //        return $"{country.Name} non è un membro dell'UE o dell'Eurozona.";
        //    }
        //}
    }
}
