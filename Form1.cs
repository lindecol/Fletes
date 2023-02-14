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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.cmbEmpresa.DataSource = FleteDao.GetEmpresas().Tables[0];
            this.cmbEmpresa.DisplayMember = "empnmb";
            this.cmbEmpresa.ValueMember = "empid";

            FrmEmpresa frm = new FrmEmpresa();

            frm.ShowDialog(this);
            this.cmbEmpresa.SelectedValue = Parametros.ParametrosIniciales.Empresa;


            //this.cmbSucursal.DataSource = FleteDao.GetSucursales(21).Tables[0];

            //this.cmbSucursal.DisplayMember = "scrnmb";
            //this.cmbSucursal.ValueMember = "scrid";




        }

        private void button1_Click(object sender, EventArgs e)
        {
            CargarHojasDeRuta();
        }

        private void CargarHojasDeRuta()
        {
            var empid = ((DataRowView)this.cmbEmpresa.SelectedItem)["empid"].ToString();
            this.grvDatos.DataSource = FleteDao.GetHr(dtpFechaIni.Value, dtpFechaFin.Value, int.Parse(empid)).Tables[0];
        }

        private void verDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.grvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro para revisar seguimiento", "Fletes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            

            var obj = (DataRowView)(this.grvDatos.SelectedRows[0]).DataBoundItem;
            var empid = int.Parse(obj["EMPID"].ToString());
            FrmDetalleHr hrdetalle = new FrmDetalleHr((obj["HOJRUT_REP"].ToString()), empid, dtpFechaIni.Value);
            hrdetalle.ShowDialog();
            CargarHojasDeRuta();


        }

        private void agregarAdicionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.grvDatos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro para Agregar Costos Adicionales", "Fletes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }



            var obj = (DataRowView)(this.grvDatos.SelectedRows[0]).DataBoundItem;


            FrmAdicionales frm = new FrmAdicionales(int.Parse(obj["HOJRUT_REP"].ToString()));

            frm.ShowDialog(this); CargarHojasDeRuta();
          
        }

        private void fletesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFletesParametrizados frm = new FrmFletesParametrizados();

            frm.ShowDialog(this);
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void conceptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConceptos frm = new FrmConceptos();

            frm.ShowDialog(this);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmCalcularFlete frm = new FrmCalcularFlete();
            frm.ShowDialog(this);

        }

        private void tsbHojasRutaCalculadas_Click(object sender, EventArgs e)
        {
            FrmTokens frm = new FrmTokens();
            frm.ShowDialog();
        }

        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
