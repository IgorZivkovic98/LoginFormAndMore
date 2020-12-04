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
    public partial class FrmPregledPrijava : Form
    {
        public FrmPregledPrijava()
        {
            InitializeComponent();
        }

        private void FrmPregledPrijava_Load(object sender, EventArgs e)
        {
            dgvPregledPrijava.DataSource = Kontroler.Kontroler.Instance.PregledPrijava();
        }

        private void dgvPregledPrijava_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
