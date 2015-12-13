using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAirport.Pim.Entities;
using MyAirport.Pim.Model;

namespace MyAirport.Pim.Model
{
    public class Natif : AbstractDefinition
    {
        public override int CreateBagage(BagageDefinition bag)
        {
            throw new NotImplementedException();
        }

        public override List<BagageDefinition> GetBagageByCodeIata(string idBagage)
        {
            throw new NotImplementedException();
        }

        public override BagageDefinition GetBagageById(int idBagage)
        {
            throw new NotImplementedException();
        }

        public override RoutageBagage GetInfoRoutage(int IdBagage)
        {
            throw new NotImplementedException();
        }
    }
}
