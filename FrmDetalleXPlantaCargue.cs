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
    public partial class FrmDetalleXPlantaCargue : Form
    {
        private int iD;
        private string _planta;

        public FrmDetalleXPlantaCargue()
        {
            InitializeComponent();
        }

        public FrmDetalleXPlantaCargue(int iD,string planta)
        {
            InitializeComponent();
            this.iD = iD;
            _planta = planta;
        }

        private void FrmDetalleXPlantaCargue_Load(object sender, EventArgs e)
        {
           grvDetalle.DataSource=  FleteDao.GetDetallexPlantaCargueAdicionales(iD, _planta);
        }

        private void verAdicionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.grvDetalle.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro para revisar Adicionales", "Fletes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            var idHr = ((DataRowView)this.grvDetalle.SelectedRows[0].DataBoundItem)["HOJARUTA"].ToString();

            FrmAdicionales frm = new FrmAdicionales(int.Parse(idHr));
            frm.ShowDialog(this);

        }
    }
}
