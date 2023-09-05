using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroCentralBank
{
    public class EUZone : Paese, IEU
    {
        public void ApplyHumanRights()
        {
            throw new NotImplementedException();
        }

        public void CoinsInstitution()
        {
            ;
        }

        public EUZone(string name): base(name)
        {
            
        }

    }
}
