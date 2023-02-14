namespace FletesLiquidos
{
    partial class FrmRutasPromedio
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTransportadora = new System.Windows.Forms.ComboBox();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GrvRutas = new System.Windows.Forms.DataGridView();
            this.empid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicu_veh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOTK_VEH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codemp_veh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_aud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APLICA_PROMEDIO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrvRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(505, 25);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton1.Image = global::FletesLiquidos.Properties.Resources.if_save_1608823;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(72, 22);
            this.toolStripButton1.Text = "Guardar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Transportadora";
            // 
            // cmbTransportadora
            // 
            this.cmbTransportadora.FormattingEnabled = true;
            this.cmbTransportadora.Location = new System.Drawing.Point(88, 46);
            this.cmbTransportadora.Name = "cmbTransportadora";
            this.cmbTransportadora.Size = new System.Drawing.Size(381, 21);
            this.cmbTransportadora.TabIndex = 18;
            this.cmbTransportadora.SelectedIndexChanged += new System.EventHandler(this.cmbTransportadora_SelectedIndexChanged);
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(88, 16);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(381, 21);
            this.cmbEmpresa.TabIndex = 20;
            this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresa_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbEmpresa);
            this.panel1.Controls.Add(this.cmbTransportadora);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 85);
            this.panel1.TabIndex = 22;
            // 
            // GrvRutas
            // 
            this.GrvRutas.AllowUserToAddRows = false;
            this.GrvRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvRutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empid,
            this.vehicu_veh,
            this.TIPOTK_VEH,
            this.codemp_veh,
            this.estado_aud,
            this.nombre,
            this.APLICA_PROMEDIO});
            this.GrvRutas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrvRutas.Location = new System.Drawing.Point(0, 110);
            this.GrvRutas.Name = "GrvRutas";
            this.GrvRutas.Size = new System.Drawing.Size(505, 345);
            this.GrvRutas.TabIndex = 23;
            // 
            // empid
            // 
            this.empid.DataPropertyName = "empid";
            this.empid.HeaderText = "empid";
            this.empid.Name = "empid";
            this.empid.Visible = false;
            // 
            // vehicu_veh
            // 
            this.vehicu_veh.DataPropertyName = "vehicu_veh";
            this.vehicu_veh.HeaderText = "Vehiculo";
            this.vehicu_veh.Name = "vehicu_veh";
            this.vehicu_veh.Width = 120;
            // 
            // TIPOTK_VEH
            // 
            this.TIPOTK_VEH.DataPropertyName = "TIPOTK_VEH";
            this.TIPOTK_VEH.HeaderText = "TIPOTK_VEH";
            this.TIPOTK_VEH.Name = "TIPOTK_VEH";
            this.TIPOTK_VEH.Visible = false;
            // 
            // codemp_veh
            // 
            this.codemp_veh.DataPropertyName = "codemp_veh";
            this.codemp_veh.HeaderText = "codemp_veh";
            this.codemp_veh.Name = "codemp_veh";
            this.codemp_veh.Visible = false;
            // 
            // estado_aud
            // 
            this.estado_aud.DataPropertyName = "estado_aud";
            this.estado_aud.HeaderText = "estado_aud";
            this.estado_aud.Name = "estado_aud";
            this.estado_aud.Visible = false;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            this.nombre.Visible = false;
            // 
            // APLICA_PROMEDIO
            // 
            this.APLICA_PROMEDIO.DataPropertyName = "APLICA_PROMEDIO";
            this.APLICA_PROMEDIO.HeaderText = "Aplica ";
            this.APLICA_PROMEDIO.Name = "APLICA_PROMEDIO";
            this.APLICA_PROMEDIO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.APLICA_PROMEDIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.APLICA_PROMEDIO.Width = 50;
            // 
            // FrmRutasPromedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 455);
            this.Controls.Add(this.GrvRutas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRutasPromedio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rutas Promedio";
            this.Load += new System.EventHandler(this.FrmRutasPromedio_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrvRutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTransportadora;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView GrvRutas;
        private System.Windows.Forms.DataGridViewTextBoxColumn empid;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicu_veh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOTK_VEH;
        private System.Windows.Forms.DataGridViewTextBoxColumn codemp_veh;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_aud;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn APLICA_PROMEDIO;
    }
}