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

        public BagageDefinition GetBagagebyCodeIata(string codeIata)
        {
            InstanceCall++;
            CountCall++;

            List<BagageDefinition> res = null;

            try
            {
                res = Factory.Model.GetBagageByCodeIata(codeIata);
                if (res != null)
                {
                    if (res.Count == 1)
                    {
                        return res[0];
                    }
                    else
                    {
                        MultipleBagageFault fault = new MultipleBagageFault();
                        fault.ListBagages = res;
                        fault.CodeIata = codeIata;
                        fault.Message = "Il existe plusieurs bagages avec le code Iata demandé";
                        throw new FaultException <MultipleBagageFault>(fault);
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (FaultException<MultipleBagageFault> excp)
            {
                throw excp;
            }
            catch (Exception)
            {
                throw new FaultException(new FaultReason("Un problème est survenue lors de votre demande, bon chance !"));
            }             
        }

        public BagageDefinition GetBagageById(int idBagage)
        {
            return Factory.Model.GetBagageById(idBagage);
        }

        public int CreateBagage(BagageDefinition bag)
        {
            return Factory.Model.CreateBagage(bag);
        }

        public RoutageBagage GetInfoRoutage(int idBagage)
        {
            return Factory.Model.GetInfoRoutage(idBagage);
        }
    }
}
