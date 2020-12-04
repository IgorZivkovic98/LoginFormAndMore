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
    public partial class FrmUnosPrijave : Form
    {
        public FrmUnosPrijave()
        {
            InitializeComponent();
        }

        private void FrmUnosPrijave_Load(object sender, EventArgs e)
        {
            cbPredmet.DataSource = Broker.BrokerBP.Instance.VratiPredmete();
            cbPredmet.DisplayMember = "Naziv";
            cbPredmet.SelectedIndex = -1;
            cbPredmet.Text = "Izaberite predmet";
        }

        private void btnPrijavi_Click(object sender, EventArgs e)
        {
            try
            {
                while (true)
                {
                    if(!String.IsNullOrEmpty(txtID.Text) && !String.IsNullOrEmpty(txtIme.Text) &&
                        !String.IsNullOrEmpty(txtPrezime.Text) && !String.IsNullOrEmpty(numOcena.Text) &&
                        !String.IsNullOrEmpty(cbPredmet.Text))
                    {
                        Prijava p = new Prijava()
                        {
                            PrijavaId = int.Parse(txtID.Text),
                            Ime = txtIme.Text,
                            Prezime = txtPrezime.Text,
                            Ocena = (int)numOcena.Value,
                            Predmet = (Predmet)cbPredmet.SelectedItem
                        };
                        Kontroler.Kontroler.Instance.SacuvajPrijavu(p);
                        MessageBox.Show("Prijava je uspesno sacuvana");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Prijava nije sacuvana");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
