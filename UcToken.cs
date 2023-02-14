using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FletesLiquidos
{
    public partial class UcToken : UserControl
    {
        public int ID { get; set; }
        public int EmpID { get; set; }

        public UcToken()
        {
            InitializeComponent();
           
        }

        public void CargarToken()
        {
            DataTable tabla = TokenDao.GetEncabezadoToken(ID);

            this.lblEmpresa.Text = tabla.Rows[0]["Empresa"].ToString();
            this.lblFechaini.Text = tabla.Rows[0]["Fecha_Ini"].ToString();
            this.lblFechafinal.Text = tabla.Rows[0]["Fecha_Fin"].ToString();

            this.lblLocalNacional.Text = tabla.Rows[0]["TipoEntrega"].ToString();

            this.lblToken.Text = tabla.Rows[0]["token"].ToString();

            this.lblUsuario.Text = tabla.Rows[0]["Usuario"].ToString();
            this.lblEmpresatra.Text = tabla.Rows[0]["Empresa_tra"].ToString();


            this.grvErrores.DataSource=TokenDao.GetErrores(ID);
            this.grvHojasRuta.DataSource = TokenDao.GetHrProcesadas(ID);
            this.grvCalculoxPlanta.DataSource = TokenDao.GetTotalXPlanta(ID);
            this.grvCalculoxSucursal.DataSource = TokenDao.GetTotalXSucursal(ID);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void verHojaDeRutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.grvErrores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro para revisar Hoja de ruta", "Fletes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }


            var obj = (DataRowView)(this.grvErrores.SelectedRows[0]).DataBoundItem;
            FrmDetalleHr hrdetalle = new FrmDetalleHr((obj["HOJRUT_REP"].ToString()), EmpID, DateTime.Parse(lblFechaini.Text));
            hrdetalle.ShowDialog(this);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (this.grvCalculoxPlanta.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro para revisar Adicionales", "Fletes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }


            var obj = (DataRowView)(this.grvCalculoxPlanta.SelectedRows[0]).DataBoundItem;

            FrmDetalleXPlantaCargue frm = new FrmDetalleXPlantaCargue(this.ID, obj["SUCURSALCLIENTE"].ToString());
            frm.ShowDialog(this);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
