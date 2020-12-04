using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domen;

namespace Forme
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


          Korisnik k = null;
        


        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            k = new Korisnik()
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            List<Korisnik> korisnici = Kontroler.Kontroler.Instance.VratiKorisnike();

            foreach (Korisnik korisnik in korisnici)
            {
                if(k.Username == korisnik.Username && k.Password == korisnik.Password)
                {
                    Kontroler.Kontroler.Instance.PrijavljenKorisnik = korisnik;
                    FrmGlavna nova = new FrmGlavna();
                    this.Hide();
                    nova.Show();
                    this.Owner = nova;
                    return;
                }
            }
            MessageBox.Show("Korisnik ne postoji u bazi!");

        }
       
    }
}
