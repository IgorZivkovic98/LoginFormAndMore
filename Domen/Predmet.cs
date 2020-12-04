using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Predmet
    {
        public int PredmetId { get; set; }
        public string Naziv { get; set; }
        public int ESPB { get; set; }
        public override string ToString()
        {
            return $"{PredmetId} {Naziv} {ESPB} ";
        }
    }
}
