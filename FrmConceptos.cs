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
    public partial class FrmConceptos : Form
    {
        public FrmConceptos()
        {
            InitializeComponent();
        }

        private void FrmConceptos_Load(object sender, EventArgs e)
        {
            this.grvDatos.DataSource = ConceptoDao.GetConceptos().Tables[0];
        }

        private void grvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmConcepto frm = new FrmConcepto();
            frm.ShowDialog(this);
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.grvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro para actualizar", "Fletes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }



            var obj = (DataRowView)(this.grvDatos.SelectedRows[0]).DataBoundItem;
            FrmConcepto frm = new FrmConcepto(int.Parse(obj["ID_CONCEPTO"].ToString()),obj.Row);
            frm.ShowDialog(this);

            this.grvDatos.DataSource = ConceptoDao.GetConceptos().Tables[0];

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.grvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro para Eliminar", "Fletes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }


            var obj = (DataRowView)(this.grvDatos.SelectedRows[0]).DataBoundItem;


            int id_concepto= int.Parse(obj["ID_CONCEPTO"].ToString());

ConceptoDao.EliminarConcepto(id_concepto);


            MessageBox.Show("Concepto Eliminado", "Fletes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            this.grvDatos.DataSource = ConceptoDao.GetConceptos().Tables[0];



        }
    }
}
