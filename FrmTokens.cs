using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FletesLiquidos
{
    public partial class FrmTokens : Form
    {
        public FrmTokens()
        {
            InitializeComponent();
        }

        private void tsbAbrir_Click(object sender, EventArgs e)
        {
            FrmAbrirToken frm = new FrmAbrirToken();
            this.ucToken1.ID = 0;
            frm.ShowDialog(this);


            if (frm.ID==0)
            {
                return;
            }

            this.ucToken1.ID = frm.ID;
            this.ucToken1.CargarToken();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmReportes frm = new FrmReportes(this.ucToken1.ID);
            frm.ShowDialog(this);
        }
    }
}
