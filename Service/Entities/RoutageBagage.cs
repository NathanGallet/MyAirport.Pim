using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAirport.Pim.Entities
{
    public class RoutageBagage
    {
        public int LocalisationEjection { get; set; }
        public string NomEjection { get; set; }
        public string StatutEjection { get; set; }

        public int LocalisationSureteN1 { get; set; }
        public string NomSureteN1 { set; get; }

        public int LocalisationSureteN3 { get; set; }
        public string NomSureteN3 { get; set; }

    }
}
