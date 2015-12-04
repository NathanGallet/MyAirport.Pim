using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MyAirport.Pim.Entities
{
    [DataContract]
    sealed public class BagageDefinition
    {
        [DataMember]
        public int IdBagage { get; set; }
        [DataMember]
        public string CodeIata { get; set; }
        [DataMember]
        public string Compagnie { get; set; }
        [DataMember]
        public int Ligne { get; set; }
        [DataMember]
        public char LigneAlpha { get; set; }
        [DataMember]
        public int JourExploitation { get; set; }
        [DataMember]
        public DateTime DateVol { get; set; }
        [DataMember]
        public string Itineraire { get; set; }
        [DataMember]
        public char ClasseBagage { get; set; }
        [DataMember]
        public bool Continuation { get; set; }
        [DataMember]
        public bool Rush { get; set; }
    }
}
