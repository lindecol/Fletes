namespace FletesLiquidos
{
    partial class FrmAbrirToken
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grvTokens = new System.Windows.Forms.DataGridView();
            this.TOKEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Compañia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPRESA_TRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOENTREGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_INI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_FIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USRID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grvTokens)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvTokens
            // 
            this.grvTokens.AllowUserToAddRows = false;
            this.grvTokens.AllowUserToDeleteRows = false;
            this.grvTokens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTokens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TOKEN,
            this.Compañia,
            this.EMPRESA_TRA,
            this.TIPOENTREGA,
            this.FECHA_INI,
            this.FECHA_FIN,
            this.FECHA,
            this.USRID});
            this.grvTokens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvTokens.Location = new System.Drawing.Point(0, 50);
            this.grvTokens.Name = "grvTokens";
            this.grvTokens.ReadOnly = true;
            this.grvTokens.Size = new System.Drawing.Size(1074, 332);
            this.grvTokens.TabIndex = 0;
            // 
            // TOKEN
            // 
            this.TOKEN.DataPropertyName = "TOKEN";
            this.TOKEN.HeaderText = "Proceso";
            this.TOKEN.Name = "TOKEN";
            this.TOKEN.ReadOnly = true;
            this.TOKEN.Width = 40;
            // 
            // Compañia
            // 
            this.Compañia.DataPropertyName = "EMPID";
            this.Compañia.HeaderText = "Compañia";
            this.Compañia.Name = "Compañia";
            this.Compañia.ReadOnly = true;
            this.Compañia.Width = 300;
            // 
            // EMPRESA_TRA
            // 
            this.EMPRESA_TRA.DataPropertyName = "EMPRESA_TRA";
            this.EMPRESA_TRA.HeaderText = "Transportadora";
            this.EMPRESA_TRA.Name = "EMPRESA_TRA";
            this.EMPRESA_TRA.ReadOnly = true;
            this.EMPRESA_TRA.Width = 300;
            // 
            // TIPOENTREGA
            // 
            this.TIPOENTREGA.DataPropertyName = "TIPOENTREGA";
            this.TIPOENTREGA.HeaderText = "Tipo Entrega";
            this.TIPOENTREGA.Name = "TIPOENTREGA";
            this.TIPOENTREGA.ReadOnly = true;
            // 
            // FECHA_INI
            // 
            this.FECHA_INI.DataPropertyName = "FECHA_INI";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.FECHA_INI.DefaultCellStyle = dataGridViewCellStyle1;
            this.FECHA_INI.HeaderText = "Fecha Inicial";
            this.FECHA_INI.Name = "FECHA_INI";
            this.FECHA_INI.ReadOnly = true;
            // 
            // FECHA_FIN
            // 
            this.FECHA_FIN.DataPropertyName = "FECHA_FIN";
            dataGridViewCellStyle2.Format = "d";
            this.FECHA_FIN.DefaultCellStyle = dataGridViewCellStyle2;
            this.FECHA_FIN.HeaderText = "Fecha Final";
            this.FECHA_FIN.Name = "FECHA_FIN";
            this.FECHA_FIN.ReadOnly = true;
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "FECHA";
            dataGridViewCellStyle3.Format = "d";
            this.FECHA.DefaultCellStyle = dataGridViewCellStyle3;
            this.FECHA.HeaderText = "Fecha Auditoria";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            // 
            // USRID
            // 
            this.USRID.DataPropertyName = "USRID";
            this.USRID.HeaderText = "USRID";
            this.USRID.Name = "USRID";
            this.USRID.ReadOnly = true;
            this.USRID.Visible = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1074, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Abrir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpFechaFinal);
            this.panel1.Controls.Add(this.dtpFechaInicial);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 50);
            this.panel1.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(704, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Final Generacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Inicial Generacion";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Location = new System.Drawing.Point(488, 13);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFinal.TabIndex = 1;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.Location = new System.Drawing.Point(144, 13);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaInicial.TabIndex = 0;
            // 
            // FrmAbrirToken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 405);
            this.Controls.Add(this.grvTokens);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmAbrirToken";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Abrir Calculo Realizado";
            this.Load += new System.EventHandler(this.FrmAbrirToken_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvTokens)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvTokens;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOKEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Compañia;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPRESA_TRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOENTREGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_INI;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_FIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn USRID;
    }
}