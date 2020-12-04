using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme
{
    public partial class FrmIzmenaKorisnika : Form
    {
        public FrmIzmenaKorisnika()
        {
            InitializeComponent();
        }

        private void FrmIzmenaKorisnika_Load(object sender, EventArgs e)
        {
            cbKorisnik.DataSource = Kontroler.Kontroler.Instance.VratiKorisnike();
            cbKorisnik.SelectedIndex = -1;
            cbKorisnik.Text = "Izaberite korisnika";
        }

        private void cbKorisnik_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Korisnik korisnik = (Korisnik)cbKorisnik.SelectedItem;
            lblID.Text = $"ID: {korisnik.Id.ToString()}";
            txtIme.Text = korisnik.Ime;
            txtPrezime.Text = korisnik.Prezime;
            txtUsername.Text = korisnik.Username;
            txtPassword.Text = korisnik.Password;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            Kontroler.Kontroler.Instance.IzmeniKorisnika(new Korisnik
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Username = txtUsername.Text,
                Password = txtPassword.Text
            });
            MessageBox.Show("Korisnik izmenjen!");
        }
    }
}
