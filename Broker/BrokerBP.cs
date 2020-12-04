using Domen;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broker
{
    public class BrokerBP
    {
        private SqlConnection konekcija;

        private static BrokerBP instance;

        public static BrokerBP Instance
        {
            get
            {
                if (instance == null) instance = new BrokerBP();
                return instance;
            }
        }

        public BrokerBP()
        {
            konekcija = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Korisnik;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public void ConnectionOpen()
        {
            konekcija.Open();
        }
        public void ConnectionClose()
        {
            konekcija.Close();
        }

        public List<Predmet> VratiPredmete()
        {
            konekcija.Open();
            List<Predmet> predmeti = new List<Predmet>();
            SqlCommand komanda = konekcija.CreateCommand();
            komanda.CommandText = "select * from Predmet";
            SqlDataReader citac = komanda.ExecuteReader();
            while (citac.Read())
            {
                Predmet p = new Predmet()
                {
                    PredmetId = citac.GetInt32(0),
                    Naziv = citac.GetString(1),
                    ESPB = citac.GetInt32(2)
                };
                predmeti.Add(p);
            }
            konekcija.Close();
            return predmeti;
        }
        public void SacuvajPrijavu(Prijava p)
        {
            SqlCommand komanda = konekcija.CreateCommand();
            komanda.CommandText = "insert into Prijava values (@PrijavaId, @Ime, @Prezime, @Ocena, @Predmet)";
            komanda.Parameters.AddWithValue("PrijavaId", p.PrijavaId);
            komanda.Parameters.AddWithValue("Ime", p.Ime);
            komanda.Parameters.AddWithValue("Prezime", p.Prezime);
            komanda.Parameters.AddWithValue("Ocena", p.Ocena);
            komanda.Parameters.AddWithValue("Predmet", p.Predmet.PredmetId);
            komanda.ExecuteNonQuery();
        }

        public List<Prijava> PregledPrijava()
        {
            List<Prijava> prijave = new List<Prijava>();

            SqlCommand komanda = konekcija.CreateCommand();
            komanda.CommandText = "select * from Prijava p join Predmet pr on (p.Predmet = pr.PredmetId)";
            SqlDataReader citac = komanda.ExecuteReader();
            while (citac.Read())
            {
                Prijava p = new Prijava()
                {
                    PrijavaId = (int)citac[0],
                    Ime = (string)citac[1],
                    Prezime = (string)citac[2],
                    Ocena = (int)citac[3],
                    Predmet = new Predmet
                    {
                        PredmetId = (int)citac[5],
                        Naziv = (string)citac[6],
                        ESPB = (int)citac[7]
                    }
                };
                prijave.Add(p);
            }
            return prijave;
        }




    }
}
