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
    public partial class FrmAbrirToken : Form
    {
        public FrmAbrirToken()
        {
            InitializeComponent();
        }

        public int ID{ get; set; }

        private void FrmAbrirToken_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ID = 0;

            if (this.grvTokens.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un registro para abrir", "Fletes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }


            var obj = (DataRowView)(this.grvTokens.SelectedRows[0]).DataBoundItem;
            var id = int.Parse(obj["TOKEN"].ToString());
            ID = id;

            this.Dispose();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.grvTokens.DataSource = TokenDao.GetTokens(this.dtpFechaInicial.Value,this.dtpFechaFinal.Value);
        }
    }
}
