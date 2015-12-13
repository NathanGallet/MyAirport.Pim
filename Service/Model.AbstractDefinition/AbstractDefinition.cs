using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAirport.Pim.Entities;

namespace MyAirport.Pim.Model
{
    public abstract class AbstractDefinition
    {
        public abstract List<BagageDefinition> GetBagageByCodeIata(string idBagage);
        public abstract BagageDefinition GetBagageById(int idBagage);
        public abstract int CreateBagage(BagageDefinition bag);
        public abstract RoutageBagage GetInfoRoutage(int IdBagage);
    }
}
