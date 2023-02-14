namespace FletesLiquidos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.grvDatos = new System.Windows.Forms.DataGridView();
            this.Revisado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EMPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_AGENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AGENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECEMI_REP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANSPORTADORA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicu_rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOJRUT_REP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KMINI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KMFIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.verDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAdicionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbHojasRutaCalculadas = new System.Windows.Forms.ToolStripButton();
            this.btnCalculo = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.conceptosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fletesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDatos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbEmpresa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpFechaFin);
            this.panel1.Controls.Add(this.dtpFechaIni);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 49);
            this.panel1.TabIndex = 0;
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.Enabled = false;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(57, 8);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(273, 21);
            this.cmbEmpresa.TabIndex = 12;
            this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Empresa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(889, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha Inicial";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(683, 11);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFin.TabIndex = 1;
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Location = new System.Drawing.Point(409, 11);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIni.TabIndex = 0;
            // 
            // grvDatos
            // 
            this.grvDatos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Revisado,
            this.EMPID,
            this.EMPRESA,
            this.COD_AGENCIA,
            this.AGENCIA,
            this.FECEMI_REP,
            this.TRANSPORTADORA,
            this.vehicu_rep,
            this.PATENTE,
            this.HOJRUT_REP,
            this.KMINI,
            this.KMFIN,
            this.TOTALKM});
            this.grvDatos.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grvDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvDatos.Location = new System.Drawing.Point(0, 74);
            this.grvDatos.Name = "grvDatos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grvDatos.Size = new System.Drawing.Size(1160, 327);
            this.grvDatos.TabIndex = 1;
            // 
            // Revisado
            // 
            this.Revisado.DataPropertyName = "aprobada";
            this.Revisado.HeaderText = "Revisado";
            this.Revisado.Name = "Revisado";
            this.Revisado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Revisado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EMPID
            // 
            this.EMPID.DataPropertyName = "EMPID";
            this.EMPID.HeaderText = "EMPID";
            this.EMPID.Name = "EMPID";
            this.EMPID.Visible = false;
            // 
            // EMPRESA
            // 
            this.EMPRESA.DataPropertyName = "EMPRESA";
            this.EMPRESA.HeaderText = "Empresa";
            this.EMPRESA.Name = "EMPRESA";
            this.EMPRESA.Width = 200;
            // 
            // COD_AGENCIA
            // 
            this.COD_AGENCIA.DataPropertyName = "COD_AGENCIA";
            this.COD_AGENCIA.HeaderText = "Cod. Suc";
            this.COD_AGENCIA.Name = "COD_AGENCIA";
            // 
            // AGENCIA
            // 
            this.AGENCIA.DataPropertyName = "AGENCIA";
            this.AGENCIA.HeaderText = "Sucursal";
            this.AGENCIA.Name = "AGENCIA";
            // 
            // FECEMI_REP
            // 
            this.FECEMI_REP.DataPropertyName = "FECEMI_REP";
            this.FECEMI_REP.HeaderText = "Fecha";
            this.FECEMI_REP.Name = "FECEMI_REP";
            // 
            // TRANSPORTADORA
            // 
            this.TRANSPORTADORA.DataPropertyName = "TRANSPORTADORA";
            this.TRANSPORTADORA.HeaderText = "Transportadora";
            this.TRANSPORTADORA.Name = "TRANSPORTADORA";
            this.TRANSPORTADORA.Width = 200;
            // 
            // vehicu_rep
            // 
            this.vehicu_rep.DataPropertyName = "VEHICU_REP";
            this.vehicu_rep.HeaderText = "Tk";
            this.vehicu_rep.Name = "vehicu_rep";
            // 
            // PATENTE
            // 
            this.PATENTE.DataPropertyName = "PATENTE";
            this.PATENTE.HeaderText = "Placa";
            this.PATENTE.Name = "PATENTE";
            // 
            // HOJRUT_REP
            // 
            this.HOJRUT_REP.DataPropertyName = "HOJRUT_REP";
            this.HOJRUT_REP.HeaderText = "Hoja de Ruta";
            this.HOJRUT_REP.Name = "HOJRUT_REP";
            // 
            // KMINI
            // 
            this.KMINI.DataPropertyName = "KMINI";
            this.KMINI.HeaderText = "Km Inicial";
            this.KMINI.Name = "KMINI";
            // 
            // KMFIN
            // 
            this.KMFIN.DataPropertyName = "KMFIN";
            this.KMFIN.HeaderText = "Km Final";
            this.KMFIN.Name = "KMFIN";
            // 
            // TOTALKM
            // 
            this.TOTALKM.DataPropertyName = "TOTALKM";
            this.TOTALKM.HeaderText = "Total Kms";
            this.TOTALKM.Name = "TOTALKM";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verDetalleToolStripMenuItem,
            this.toolStripMenuItem1,
            this.agregarAdicionalesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 54);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 6);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbHojasRutaCalculadas,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.btnCalculo,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1160, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // verDetalleToolStripMenuItem
            // 
            this.verDetalleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.verDetalleToolStripMenuItem.Image = global::FletesLiquidos.Properties.Resources.if_11_Search_106236;
            this.verDetalleToolStripMenuItem.Name = "verDetalleToolStripMenuItem";
            this.verDetalleToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.verDetalleToolStripMenuItem.Text = "Ver Detalle";
            this.verDetalleToolStripMenuItem.Click += new System.EventHandler(this.verDetalleToolStripMenuItem_Click);
            // 
            // agregarAdicionalesToolStripMenuItem
            // 
            this.agregarAdicionalesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.agregarAdicionalesToolStripMenuItem.Image = global::FletesLiquidos.Properties.Resources.iconfinder_199_CircledPlus_183316;
            this.agregarAdicionalesToolStripMenuItem.Name = "agregarAdicionalesToolStripMenuItem";
            this.agregarAdicionalesToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.agregarAdicionalesToolStripMenuItem.Text = "Agregar Adicionales";
            this.agregarAdicionalesToolStripMenuItem.Click += new System.EventHandler(this.agregarAdicionalesToolStripMenuItem_Click);
            // 
            // tsbHojasRutaCalculadas
            // 
            this.tsbHojasRutaCalculadas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbHojasRutaCalculadas.Image = global::FletesLiquidos.Properties.Resources.if_11_Search_106236;
            this.tsbHojasRutaCalculadas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHojasRutaCalculadas.Name = "tsbHojasRutaCalculadas";
            this.tsbHojasRutaCalculadas.Size = new System.Drawing.Size(160, 22);
            this.tsbHojasRutaCalculadas.Text = "Buscar Fletes Calculados";
            this.tsbHojasRutaCalculadas.Click += new System.EventHandler(this.tsbHojasRutaCalculadas_Click);
            // 
            // btnCalculo
            // 
            this.btnCalculo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCalculo.Image = global::FletesLiquidos.Properties.Resources.iconfinder_vehicles_11_809733;
            this.btnCalculo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(168, 22);
            this.btnCalculo.Text = "Generar Calculo de Fletes";
            this.btnCalculo.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conceptosToolStripMenuItem,
            this.fletesToolStripMenuItem});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(125, 22);
            this.toolStripDropDownButton1.Text = "Configuraciones";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // conceptosToolStripMenuItem
            // 
            this.conceptosToolStripMenuItem.Image = global::FletesLiquidos.Properties.Resources.if_order_2639879;
            this.conceptosToolStripMenuItem.Name = "conceptosToolStripMenuItem";
            this.conceptosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.conceptosToolStripMenuItem.Text = "Conceptos";
            this.conceptosToolStripMenuItem.Click += new System.EventHandler(this.conceptosToolStripMenuItem_Click);
            // 
            // fletesToolStripMenuItem
            // 
            this.fletesToolStripMenuItem.Image = global::FletesLiquidos.Properties.Resources.iconfinder_1_1668045;
            this.fletesToolStripMenuItem.Name = "fletesToolStripMenuItem";
            this.fletesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.fletesToolStripMenuItem.Text = "Fletes";
            this.fletesToolStripMenuItem.Click += new System.EventHandler(this.fletesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 401);
            this.Controls.Add(this.grvDatos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fletes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvDatos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.DataGridView grvDatos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verDetalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarAdicionalesToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem conceptosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fletesToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnCalculo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Revisado;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPRESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_AGENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn AGENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECEMI_REP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TRANSPORTADORA;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicu_rep;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOJRUT_REP;
        private System.Windows.Forms.DataGridViewTextBoxColumn KMINI;
        private System.Windows.Forms.DataGridViewTextBoxColumn KMFIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALKM;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbHojasRutaCalculadas;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label label3;
    }
}

