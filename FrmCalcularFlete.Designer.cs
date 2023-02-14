namespace FletesLiquidos
{
    partial class FrmCalcularFlete
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
            this.components = new System.ComponentModel.Container();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTransportadora = new System.Windows.Forms.ComboBox();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLocalNacional = new System.Windows.Forms.ComboBox();
            this.localNacionalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucToken1 = new FletesLiquidos.UcToken();
            ((System.ComponentModel.ISupportInitialize)(this.localNacionalBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Location = new System.Drawing.Point(93, 40);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(213, 20);
            this.dtpFechaIni.TabIndex = 0;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(380, 40);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(214, 20);
            this.dtpFechaFin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Final";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(809, 13);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(99, 46);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Empresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Transportadora";
            // 
            // cmbTransportadora
            // 
            this.cmbTransportadora.FormattingEnabled = true;
            this.cmbTransportadora.Location = new System.Drawing.Point(475, 13);
            this.cmbTransportadora.Name = "cmbTransportadora";
            this.cmbTransportadora.Size = new System.Drawing.Size(328, 21);
            this.cmbTransportadora.TabIndex = 8;
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(93, 13);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(291, 21);
            this.cmbEmpresa.TabIndex = 10;
            this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresa_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Local/nacional";
            // 
            // cmbLocalNacional
            // 
            this.cmbLocalNacional.DataSource = this.localNacionalBindingSource;
            this.cmbLocalNacional.DisplayMember = "Codigo";
            this.cmbLocalNacional.FormattingEnabled = true;
            this.cmbLocalNacional.Location = new System.Drawing.Point(684, 40);
            this.cmbLocalNacional.Name = "cmbLocalNacional";
            this.cmbLocalNacional.Size = new System.Drawing.Size(119, 21);
            this.cmbLocalNacional.TabIndex = 12;
            this.cmbLocalNacional.ValueMember = "Nombre";
            // 
            // localNacionalBindingSource
            // 
            this.localNacionalBindingSource.DataSource = typeof(FletesLiquidos.LocalNacional);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbEmpresa);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpFechaIni);
            this.panel1.Controls.Add(this.cmbLocalNacional);
            this.panel1.Controls.Add(this.dtpFechaFin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbTransportadora);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 83);
            this.panel1.TabIndex = 13;
            // 
            // ucToken1
            // 
            this.ucToken1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucToken1.Location = new System.Drawing.Point(0, 83);
            this.ucToken1.Name = "ucToken1";
            this.ucToken1.Size = new System.Drawing.Size(1175, 403);
            this.ucToken1.TabIndex = 14;
            // 
            // FrmCalcularFlete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 486);
            this.Controls.Add(this.ucToken1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCalcularFlete";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calcular Fletes";
            this.Load += new System.EventHandler(this.FrmCalcularFlete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.localNacionalBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTransportadora;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLocalNacional;
        private System.Windows.Forms.BindingSource localNacionalBindingSource;
        private System.Windows.Forms.Panel panel1;
        private UcToken ucToken1;
    }
}