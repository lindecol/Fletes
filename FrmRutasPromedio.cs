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
    public partial class FrmRutasPromedio : Form
    {
        DataTable dsRutas;

        public FrmRutasPromedio()
        {
            InitializeComponent();
        }

        private void FrmRutasPromedio_Load(object sender, EventArgs e)
        {
            this.cmbEmpresa.DataSource = FleteDao.GetEmpresas().Tables[0];
            this.cmbEmpresa.DisplayMember = "empnmb";
            this.cmbEmpresa.ValueMember = "empid";

        }

        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
          var  alias = ((DataRowView)cmbEmpresa.SelectedItem)["empalias"].ToString();

            try
            {

                this.cmbTransportadora.DataSource = FleteDao.GetTransportadoras(alias).Tables[0];
                this.cmbTransportadora.DisplayMember = "nombre_tra";
                this.cmbTransportadora.ValueMember = "empres_tra";
            }
            catch (Exception)
            {
            }

        }

        private void cmbTransportadora_SelectedIndexChanged(object sender, EventArgs e)
        {
            var empresa = ((DataRowView)cmbEmpresa.SelectedItem)["empid"].ToString();
            try {

                var alias = ((DataRowView)cmbEmpresa.SelectedItem)["empalias"].ToString();
              

                dsRutas = FleteDao.GetVehiculoPromedio(((DataRowView)cmbTransportadora.SelectedItem)["empres_tra"].ToString(), alias, empresa).Tables[0];

                this.GrvRutas.DataSource = dsRutas;
            }
            catch (Exception ex)
            {


            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {

          
            foreach (DataRow item in dsRutas.Rows)
            {
                FleteDao.ActualizarRutaPromedio(item);
            }

            MessageBox.Show("Registros Actualizados");
            }
            catch (Exception ex)
            {

                MessageBox.Show("ocurrio un error actualizando ruta " + ex.Message) ;
            }

        }
    }
}
