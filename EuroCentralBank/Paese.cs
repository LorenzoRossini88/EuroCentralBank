using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCentralBank
{
    public abstract class Paese : IONU
    {
        public string Name { get; set; }
        //public bool IsEurozoneMember { get; set; }
        //public bool IsEUMember { get; set; }
        //public PenaDiMorteEnum DeathPenalty { get; set; }


        void IONU.PopulationControl()
        {
            throw new NotImplementedException();
        }

        void IONU.TerritoryControl()
        {
            throw new NotImplementedException();
        }

        public Paese(string name)
        {
            this.Name = name;
            
        }
    }
}
