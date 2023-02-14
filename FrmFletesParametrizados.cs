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
    public partial class FrmFletesParametrizados : Form
    {
        public FrmFletesParametrizados()
        {
            InitializeComponent();
        }

       public DataSet FletesParametrizados = new DataSet();

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmParametrizacionFletes frm = new FrmParametrizacionFletes();

            frm.ShowDialog(this);

            RefrescarGrilla();

        }

        private void FrmFletesParametrizados_Load(object sender, EventArgs e)
        {
            RefrescarGrilla();

        }

        private void RefrescarGrilla()
        {
            FletesParametrizados = FleteDao.CargarFleteConfig();
            this.grvFletes.DataSource = FletesParametrizados.Tables[0];
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.grvFletes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro para eliminar", "Fletes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }



            var obj = (DataRowView)(this.grvFletes.SelectedRows[0]).DataBoundItem;

            FleteDao.EliminarFleteConfig(int.Parse(obj["ID"].ToString()));

            MessageBox.Show("Registro Eliminado", "Fletes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            RefrescarGrilla();



        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var obj = (DataRowView)(this.grvFletes.SelectedRows[0]).DataBoundItem;
            FrmParametrizacionFletes frm = new FrmParametrizacionFletes(int.Parse(obj["ID"].ToString()));

            frm.ShowDialog(this);
            RefrescarGrilla();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FrmRutasPromedio frm = new FrmRutasPromedio();

            frm.ShowDialog(this);

        }
    }
}
