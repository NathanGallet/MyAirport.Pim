using MyAirport.Serveur;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MyAirport.Pim.Entities;
using MyAirport.Pim.Model;

namespace MyAirport.Serveur
{
   
    public class Service : IService
    {

        public static int NbInstance = 0;
        public static int CountCreate = 0;
        public static int CountCall = 0;
        public int InstanceCall = 0;

        public Service()
        {
            int val = CountCreate++;
            NbInstance++;
        }

        ~Service()
        {
            NbInstance--;
        }

        public MyAirport.Pim.Entities.BagageDefinition GetBagagebyCodeIata(string codeIata)
        {
            return MyAirport.Pim.Model.Factory.Model.GetBagageByCodeIata(codeIata);
        }

        public BagageDefinition GetBagageById(int idBagage)
        {
            return MyAirport.Pim.Model.Factory.Model.GetBagageById(idBagage);
        }

        public int CreateBagage(BagageDefinition bag)
        {
            return MyAirport.Pim.Model.Factory.Model.CreateBagage(bag);
        }

        public RoutageBagage GetInfoRoutage(int idBagage)
        {
            return MyAirport.Pim.Model.Factory.Model.GetInfoRoutage(idBagage);
        }
    }
}
