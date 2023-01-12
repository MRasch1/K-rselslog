using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kørselslog
{
    public class Personale
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public string OpdaterNavn { get; set; }
        public DateTime Dato { get; set; }
        public DateTime OpdaterDato { get; set; }

    }
}
