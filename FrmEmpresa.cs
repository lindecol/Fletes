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
    public partial class FrmEmpresa : Form
    {
        public FrmEmpresa()
        {
            InitializeComponent();
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = FleteDao.GetEmpresas().Tables[0];
            this.comboBox1.DisplayMember = "EMPNMB";
            this.comboBox1.ValueMember = "EMPID";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var empid = int.Parse(((DataRowView)this.comboBox1.SelectedItem)["Empid"].ToString());
            Parametros.ParametrosIniciales.Empresa = empid;
            this.Dispose();
        }
    }
}
