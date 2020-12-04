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
    public partial class FrmGlavna : Form
    {
        public FrmGlavna()
        {
            InitializeComponent();
        }

        private void FrmGlavna_Load(object sender, EventArgs e)
        {
            lblUser.Text = $"Korisnik: {Kontroler.Kontroler.Instance.PrijavljenKorisnik.Ime} {Kontroler.Kontroler.Instance.PrijavljenKorisnik.Prezime}";
        }

        private void unosPrijaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUnosPrijave nova = new FrmUnosPrijave();
            this.Hide();
            nova.Show();
            this.Owner = nova;
        }

        private void pregledPrijavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPregledPrijava nova = new FrmPregledPrijava();
            this.Hide();
            nova.Show();
            this.Owner = nova;
        }

        private void izmenaKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIzmenaKorisnika nova = new FrmIzmenaKorisnika();
            this.Hide();
            nova.Show();
            this.Owner = nova;
        }
    }
}
