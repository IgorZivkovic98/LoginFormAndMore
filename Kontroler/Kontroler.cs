using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domen;
using Broker;

namespace Kontroler
{
    public class Kontroler
    {
        Broker.BrokerBP broker = new BrokerBP();

        public List<Korisnik> korisnici = new List<Korisnik>
        {
            new Korisnik{Id = 1, Ime = "Pera", Prezime = "Peric", Username = "pera", Password = "pera"},
            new Korisnik{Id = 1, Ime = "Psdasdaera", Prezime = "Peric", Username = "asd", Password = "asd"},
            new Korisnik{Id = 1, Ime = "sdaf", Prezime = "Peric", Username = "dsa", Password = "dsa"}
        };

        public List<Korisnik> VratiKorisnike()
        {
            return korisnici;
        }

        public Korisnik PrijavljenKorisnik { get; set; }


        private static Kontroler instance;

        public static Kontroler Instance
        {
            get
            {
                if (instance == null) instance = new Kontroler();
                return instance;
            }
        }

        public void SacuvajPrijavu(Prijava p)
        {
            try
            {
                broker.ConnectionOpen();
                broker.SacuvajPrijavu(p);
            }
            finally
            {
                broker.ConnectionClose();
            }
        }

        public List<Prijava> PregledPrijava()
        {
            try
            {
                broker.ConnectionOpen();
                return broker.PregledPrijava();
            }
            finally
            {
                broker.ConnectionClose();
            }
        }

        public void IzmeniKorisnika(Korisnik korisnik)
        {
            foreach (Korisnik k in korisnici)
            {
                if(k.Id == korisnik.Id)
                {
                    k.Username = korisnik.Username;
                    k.Ime = korisnik.Ime;
                    k.Password = korisnik.Password;
                    k.Prezime = korisnik.Prezime;
                }
            }
        }

    }
}
