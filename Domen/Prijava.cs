using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Prijava
    {
        public int PrijavaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Ocena { get; set; }
        public Predmet Predmet { get; set; }
    }
}
