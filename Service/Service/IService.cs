using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyAirport.Serveur
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IService1" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [FaultContract(typeof(MyAirport.Pim.Entities.MultipleBagageFault))]
        MyAirport.Pim.Entities.BagageDefinition GetBagagebyCodeIata(string codeIata);

        [OperationContract]
        MyAirport.Pim.Entities.BagageDefinition GetBagageById(int idBagage);

        [OperationContract]
        int CreateBagage(MyAirport.Pim.Entities.BagageDefinition bag);

        [OperationContract]
        MyAirport.Pim.Entities.RoutageBagage GetInfoRoutage(int idBagage);
    }
}
