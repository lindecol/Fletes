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
    public partial class FrmCalcularFlete : Form
    {
        public FrmCalcularFlete()
        {
            InitializeComponent();
        }
        string alias = "";

        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            alias = ((DataRowView)cmbEmpresa.SelectedItem)["empalias"].ToString();

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

        private void FrmCalcularFlete_Load(object sender, EventArgs e)
        {
            this.cmbEmpresa.DataSource = FleteDao.GetEmpresas().Tables[0];
            this.cmbEmpresa.DisplayMember = "empnmb";
            this.cmbEmpresa.ValueMember = "empid";
            this.cmbLocalNacional.DataSource=LocalNacional.getLocalNacional();

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            var empresa = int.Parse(((DataRowView)cmbEmpresa.SelectedItem)["empid"].ToString());
            var transportadora = ((DataRowView)cmbTransportadora.SelectedItem)["empres_tra"].ToString();
            var localNacional = ((LocalNacional)cmbLocalNacional.SelectedItem).Codigo;

           var token =  FleteDao.CalcularFLetes(empresa, transportadora, localNacional, dtpFechaIni.Value, dtpFechaFin.Value);

            ucToken1.ID = token;
            ucToken1.EmpID = empresa;
            ucToken1.CargarToken();
            ///
        }
    }
}
