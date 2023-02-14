namespace FletesLiquidos
{
    partial class FrmParametrizacionFletes
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTransportadora = new System.Windows.Forms.ComboBox();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudRinicial = new System.Windows.Forms.NumericUpDown();
            this.nudRfinal = new System.Windows.Forms.NumericUpDown();
            this.lblrfinal = new System.Windows.Forms.Label();
            this.lblRinicial = new System.Windows.Forms.Label();
            this.nudValorKm = new System.Windows.Forms.NumericUpDown();
            this.lblValorxkm = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLocalNacional = new System.Windows.Forms.ComboBox();
            this.localNacionalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoProducto = new System.Windows.Forms.ComboBox();
            this.tipoProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.rbFijo = new System.Windows.Forms.RadioButton();
            this.rbVariable = new System.Windows.Forms.RadioButton();
            this.rbFijoVariable = new System.Windows.Forms.RadioButton();
            this.lblValorFijo = new System.Windows.Forms.Label();
            this.NudFijo = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkAplicaPromedio = new System.Windows.Forms.CheckBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregaRuta = new System.Windows.Forms.Button();
            this.grvRutas = new System.Windows.Forms.DataGridView();
            this.id_config = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculo_veh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplica_promedio = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudRinicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRfinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorKm)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localNacionalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudFijo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transportadora";
            // 
            // cmbTransportadora
            // 
            this.cmbTransportadora.Enabled = false;
            this.cmbTransportadora.FormattingEnabled = true;
            this.cmbTransportadora.Location = new System.Drawing.Point(106, 43);
            this.cmbTransportadora.Name = "cmbTransportadora";
            this.cmbTransportadora.Size = new System.Drawing.Size(291, 21);
            this.cmbTransportadora.TabIndex = 1;
            this.cmbTransportadora.SelectedIndexChanged += new System.EventHandler(this.cmbTransportadora_SelectedIndexChanged);
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.Enabled = false;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(106, 13);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(291, 21);
            this.cmbEmpresa.TabIndex = 3;
            this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresa_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empresa";
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.FormattingEnabled = true;
            this.cmbVehiculo.Location = new System.Drawing.Point(66, 6);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(291, 21);
            this.cmbVehiculo.TabIndex = 5;
            this.cmbVehiculo.SelectedIndexChanged += new System.EventHandler(this.cmbVehiculo_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vehiculo";
            // 
            // nudRinicial
            // 
            this.nudRinicial.Location = new System.Drawing.Point(105, 120);
            this.nudRinicial.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudRinicial.Name = "nudRinicial";
            this.nudRinicial.Size = new System.Drawing.Size(120, 20);
            this.nudRinicial.TabIndex = 10;
            this.nudRinicial.Visible = false;
            // 
            // nudRfinal
            // 
            this.nudRfinal.Location = new System.Drawing.Point(277, 120);
            this.nudRfinal.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudRfinal.Name = "nudRfinal";
            this.nudRfinal.Size = new System.Drawing.Size(120, 20);
            this.nudRfinal.TabIndex = 11;
            this.nudRfinal.Visible = false;
            // 
            // lblrfinal
            // 
            this.lblrfinal.AutoSize = true;
            this.lblrfinal.Location = new System.Drawing.Point(25, 122);
            this.lblrfinal.Name = "lblrfinal";
            this.lblrfinal.Size = new System.Drawing.Size(40, 13);
            this.lblrfinal.TabIndex = 12;
            this.lblrfinal.Text = "R Final";
            this.lblrfinal.Visible = false;
            // 
            // lblRinicial
            // 
            this.lblRinicial.AutoSize = true;
            this.lblRinicial.Location = new System.Drawing.Point(231, 122);
            this.lblRinicial.Name = "lblRinicial";
            this.lblRinicial.Size = new System.Drawing.Size(40, 13);
            this.lblRinicial.TabIndex = 13;
            this.lblRinicial.Text = "R Final";
            this.lblRinicial.Visible = false;
            // 
            // nudValorKm
            // 
            this.nudValorKm.Location = new System.Drawing.Point(105, 148);
            this.nudValorKm.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nudValorKm.Name = "nudValorKm";
            this.nudValorKm.Size = new System.Drawing.Size(120, 20);
            this.nudValorKm.TabIndex = 14;
            this.nudValorKm.Visible = false;
            // 
            // lblValorxkm
            // 
            this.lblValorxkm.AutoSize = true;
            this.lblValorxkm.Location = new System.Drawing.Point(21, 150);
            this.lblValorxkm.Name = "lblValorxkm";
            this.lblValorxkm.Size = new System.Drawing.Size(57, 13);
            this.lblValorxkm.TabIndex = 15;
            this.lblValorxkm.Text = "Valor x Km";
            this.lblValorxkm.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(699, 25);
            this.toolStrip1.TabIndex = 16;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Local/nacional";
            // 
            // cmbLocalNacional
            // 
            this.cmbLocalNacional.DataSource = this.localNacionalBindingSource;
            this.cmbLocalNacional.DisplayMember = "Codigo";
            this.cmbLocalNacional.FormattingEnabled = true;
            this.cmbLocalNacional.Location = new System.Drawing.Point(107, 185);
            this.cmbLocalNacional.Name = "cmbLocalNacional";
            this.cmbLocalNacional.Size = new System.Drawing.Size(119, 21);
            this.cmbLocalNacional.TabIndex = 7;
            this.cmbLocalNacional.ValueMember = "Nombre";
            // 
            // localNacionalBindingSource
            // 
            this.localNacionalBindingSource.DataSource = typeof(FletesLiquidos.LocalNacional);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo Prod+";
            // 
            // cmbTipoProducto
            // 
            this.cmbTipoProducto.DataSource = this.tipoProductoBindingSource;
            this.cmbTipoProducto.DisplayMember = "Nombre";
            this.cmbTipoProducto.FormattingEnabled = true;
            this.cmbTipoProducto.Location = new System.Drawing.Point(107, 212);
            this.cmbTipoProducto.Name = "cmbTipoProducto";
            this.cmbTipoProducto.Size = new System.Drawing.Size(119, 21);
            this.cmbTipoProducto.TabIndex = 9;
            this.cmbTipoProducto.ValueMember = "Codigo";
            // 
            // tipoProductoBindingSource
            // 
            this.tipoProductoBindingSource.DataSource = typeof(FletesLiquidos.TipoProducto);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tipo liquidacion";
            // 
            // rbFijo
            // 
            this.rbFijo.AutoSize = true;
            this.rbFijo.Location = new System.Drawing.Point(107, 71);
            this.rbFijo.Name = "rbFijo";
            this.rbFijo.Size = new System.Drawing.Size(41, 17);
            this.rbFijo.TabIndex = 18;
            this.rbFijo.TabStop = true;
            this.rbFijo.Text = "Fijo";
            this.rbFijo.UseVisualStyleBackColor = true;
            this.rbFijo.CheckedChanged += new System.EventHandler(this.rbFijo_CheckedChanged);
            // 
            // rbVariable
            // 
            this.rbVariable.AutoSize = true;
            this.rbVariable.Location = new System.Drawing.Point(162, 71);
            this.rbVariable.Name = "rbVariable";
            this.rbVariable.Size = new System.Drawing.Size(63, 17);
            this.rbVariable.TabIndex = 19;
            this.rbVariable.TabStop = true;
            this.rbVariable.Text = "Variable";
            this.rbVariable.UseVisualStyleBackColor = true;
            this.rbVariable.CheckedChanged += new System.EventHandler(this.rbFijo_CheckedChanged);
            // 
            // rbFijoVariable
            // 
            this.rbFijoVariable.AutoSize = true;
            this.rbFijoVariable.Location = new System.Drawing.Point(235, 71);
            this.rbFijoVariable.Name = "rbFijoVariable";
            this.rbFijoVariable.Size = new System.Drawing.Size(91, 17);
            this.rbFijoVariable.TabIndex = 20;
            this.rbFijoVariable.TabStop = true;
            this.rbFijoVariable.Text = "Fijo + Variable";
            this.rbFijoVariable.UseVisualStyleBackColor = true;
            this.rbFijoVariable.Visible = false;
            this.rbFijoVariable.CheckedChanged += new System.EventHandler(this.rbFijo_CheckedChanged);
            // 
            // lblValorFijo
            // 
            this.lblValorFijo.AutoSize = true;
            this.lblValorFijo.Location = new System.Drawing.Point(21, 96);
            this.lblValorFijo.Name = "lblValorFijo";
            this.lblValorFijo.Size = new System.Drawing.Size(50, 13);
            this.lblValorFijo.TabIndex = 22;
            this.lblValorFijo.Text = "Valor Fijo";
            this.lblValorFijo.Visible = false;
            // 
            // NudFijo
            // 
            this.NudFijo.Location = new System.Drawing.Point(105, 94);
            this.NudFijo.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.NudFijo.Name = "NudFijo";
            this.NudFijo.Size = new System.Drawing.Size(120, 20);
            this.NudFijo.TabIndex = 21;
            this.NudFijo.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblValorFijo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NudFijo);
            this.panel1.Controls.Add(this.cmbTransportadora);
            this.panel1.Controls.Add(this.rbFijoVariable);
            this.panel1.Controls.Add(this.cmbEmpresa);
            this.panel1.Controls.Add(this.rbVariable);
            this.panel1.Controls.Add(this.rbFijo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbLocalNacional);
            this.panel1.Controls.Add(this.lblValorxkm);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nudValorKm);
            this.panel1.Controls.Add(this.cmbTipoProducto);
            this.panel1.Controls.Add(this.lblRinicial);
            this.panel1.Controls.Add(this.nudRinicial);
            this.panel1.Controls.Add(this.lblrfinal);
            this.panel1.Controls.Add(this.nudRfinal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 251);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chkAplicaPromedio);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnAgregaRuta);
            this.panel2.Controls.Add(this.cmbVehiculo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(699, 36);
            this.panel2.TabIndex = 24;
            // 
            // chkAplicaPromedio
            // 
            this.chkAplicaPromedio.AutoSize = true;
            this.chkAplicaPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAplicaPromedio.Location = new System.Drawing.Point(364, 9);
            this.chkAplicaPromedio.Name = "chkAplicaPromedio";
            this.chkAplicaPromedio.Size = new System.Drawing.Size(117, 17);
            this.chkAplicaPromedio.TabIndex = 8;
            this.chkAplicaPromedio.Text = "Aplica Promedio";
            this.chkAplicaPromedio.UseVisualStyleBackColor = true;
            this.chkAplicaPromedio.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(605, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(77, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregaRuta
            // 
            this.btnAgregaRuta.Location = new System.Drawing.Point(522, 3);
            this.btnAgregaRuta.Name = "btnAgregaRuta";
            this.btnAgregaRuta.Size = new System.Drawing.Size(77, 23);
            this.btnAgregaRuta.TabIndex = 6;
            this.btnAgregaRuta.Text = "Agregar";
            this.btnAgregaRuta.UseVisualStyleBackColor = true;
            this.btnAgregaRuta.Click += new System.EventHandler(this.btnAgregaRuta_Click);
            // 
            // grvRutas
            // 
            this.grvRutas.AllowUserToAddRows = false;
            this.grvRutas.AllowUserToDeleteRows = false;
            this.grvRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvRutas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_config,
            this.vehiculo_veh,
            this.estado_reg,
            this.aplica_promedio});
            this.grvRutas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvRutas.Location = new System.Drawing.Point(0, 312);
            this.grvRutas.Name = "grvRutas";
            this.grvRutas.ReadOnly = true;
            this.grvRutas.Size = new System.Drawing.Size(699, 179);
            this.grvRutas.TabIndex = 25;
            this.grvRutas.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.grvRutas_RowStateChanged);
            // 
            // id_config
            // 
            this.id_config.DataPropertyName = "id_config";
            this.id_config.HeaderText = "id_config";
            this.id_config.Name = "id_config";
            this.id_config.ReadOnly = true;
            this.id_config.Visible = false;
            // 
            // vehiculo_veh
            // 
            this.vehiculo_veh.DataPropertyName = "vehiculo_veh";
            this.vehiculo_veh.HeaderText = "Vehiculo";
            this.vehiculo_veh.Name = "vehiculo_veh";
            this.vehiculo_veh.ReadOnly = true;
            this.vehiculo_veh.Width = 300;
            // 
            // estado_reg
            // 
            this.estado_reg.DataPropertyName = "estado_reg";
            this.estado_reg.HeaderText = "estado_reg";
            this.estado_reg.Name = "estado_reg";
            this.estado_reg.ReadOnly = true;
            this.estado_reg.Visible = false;
            // 
            // aplica_promedio
            // 
            this.aplica_promedio.DataPropertyName = "aplica_promedio";
            this.aplica_promedio.HeaderText = "Aplica Promedio";
            this.aplica_promedio.Name = "aplica_promedio";
            this.aplica_promedio.ReadOnly = true;
            this.aplica_promedio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.aplica_promedio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.aplica_promedio.Visible = false;
            // 
            // FrmParametrizacionFletes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 491);
            this.Controls.Add(this.grvRutas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmParametrizacionFletes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Parametrizacion de Fletes";
            this.Load += new System.EventHandler(this.FrmParametrizacionFletes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRinicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRfinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorKm)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localNacionalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudFijo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvRutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTransportadora;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudRinicial;
        private System.Windows.Forms.NumericUpDown nudRfinal;
        private System.Windows.Forms.Label lblrfinal;
        private System.Windows.Forms.Label lblRinicial;
        private System.Windows.Forms.NumericUpDown nudValorKm;
        private System.Windows.Forms.Label lblValorxkm;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLocalNacional;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rbFijo;
        private System.Windows.Forms.RadioButton rbVariable;
        private System.Windows.Forms.RadioButton rbFijoVariable;
        private System.Windows.Forms.Label lblValorFijo;
        private System.Windows.Forms.NumericUpDown NudFijo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAgregaRuta;
        private System.Windows.Forms.DataGridView grvRutas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox chkAplicaPromedio;
        private System.Windows.Forms.BindingSource tipoProductoBindingSource;
        private System.Windows.Forms.BindingSource localNacionalBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_config;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehiculo_veh;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_reg;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aplica_promedio;
    }
}