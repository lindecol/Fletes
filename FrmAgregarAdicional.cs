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
    public partial class FrmAgregarAdicional : Form
    {

        int _idHojaRuta;

        public FrmAgregarAdicional(int idHojaRuta)
        {
            InitializeComponent();
            _idHojaRuta = idHojaRuta;
     

        }

      

        private void FrmAgregarAdicional_Load(object sender, EventArgs e)
        {

            this.cmbConcepto.DataSource = FleteDao.GetConceptos().Tables[0];
            this.cmbConcepto.DisplayMember = "DESCRIPCION";
            this.cmbConcepto.ValueMember = "ID_CONCEPTO";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            FleteDao.GUardarAdicional(_idHojaRuta,
                                int.Parse(((DataRowView)this.cmbConcepto.SelectedItem)["ID_CONCEPTO"].ToString()),
                                nudValor.Value * int.Parse(((DataRowView)this.cmbConcepto.SelectedItem)["tipo_concepto"].ToString()),
                                this.txtObservaciones.Text);

            this.Dispose();
        }
    }
}
