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
    public partial class FrmAdicionales : Form
    {
        int _idHojaRuta;
        public FrmAdicionales(int idHojaruta)
        {
            InitializeComponent();

            _idHojaRuta = idHojaruta;
            RefrescarGrilla();
        }

        private void RefrescarGrilla()
        {
            this.dataGridView1.DataSource = FleteDao.GetAdicionales(_idHojaRuta).Tables[0];
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmAgregarAdicional FRM = new FrmAgregarAdicional(_idHojaRuta);
            FRM.ShowDialog(this);
            RefrescarGrilla();


        }

        private void FrmAdicionales_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            var registros = ((DataTable)dataGridView1.DataSource).AsEnumerable().Where(x => int.Parse(x["MODIFICADO"].ToString()) == 1);

            foreach (var item in registros)
            {
                FleteDao.ActualizarAdicional(item);
            }

            MessageBox.Show("Se actualizaron " + registros.Count() + " registros");
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            var tabla = (DataTable)this.dataGridView1.DataSource;

            tabla.Rows[e.RowIndex]["MODIFICADO"] = 1;

        }
    }
}
