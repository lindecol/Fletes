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
    public partial class FrmConcepto : Form
    {
        int _idConcepto = 0;
        DataRow _fila;

        public FrmConcepto(int idConcepto, DataRow fila)
        {
            InitializeComponent();
            _idConcepto = idConcepto;
            _fila = fila;

            this.txtConcepto.Text = fila["Descripcion"].ToString();
            rbSuma.Checked = fila["tipo_concepto"].ToString()== "SUMA" ? true : false;
            rbResta.Checked = !rbSuma.Checked;
        }

        public FrmConcepto()
        {
            InitializeComponent();
        }

        private void FrmConceptos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!rbSuma.Checked && !rbResta.Checked)
            {
                MessageBox.Show("No ha seleccionado el tipo de concepto", "Fletes", MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
                return;
            }


            ConceptoDao.InsertaConcepto(_idConcepto, txtConcepto.Text.ToUpper(), rbSuma.Checked ? 1 : 0);
            MessageBox.Show("Registro Almacenado");
            this.Dispose();

        }
    }
}
