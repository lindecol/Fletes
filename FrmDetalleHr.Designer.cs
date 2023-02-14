namespace FletesLiquidos
{
    partial class FrmDetalleHr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalleHr));
            this.grvDetalle = new System.Windows.Forms.DataGridView();
            this.EMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consecutivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HojaRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUCURSALCLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanque_rep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanquedsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KILOMETRAJEDIF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODIFICADO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ORDEN_REP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnAprobarHr = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCancelarAprobacion = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetalle)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvDetalle
            // 
            this.grvDetalle.AllowUserToAddRows = false;
            this.grvDetalle.AllowUserToDeleteRows = false;
            this.grvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EMPRESA,
            this.consecutivo,
            this.HojaRuta,
            this.SUCURSALCLIENTE,
            this.CodCliente,
            this.nombreCliente,
            this.tanque_rep,
            this.tanquedsc,
            this.kmLlegada,
            this.KILOMETRAJEDIF,
            this.total,
            this.MODIFICADO,
            this.ORDEN_REP});
            this.grvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvDetalle.Location = new System.Drawing.Point(0, 25);
            this.grvDetalle.Name = "grvDetalle";
            this.grvDetalle.Size = new System.Drawing.Size(1261, 366);
            this.grvDetalle.TabIndex = 0;
            this.grvDetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvDetalle_CellEndEdit);
            this.grvDetalle.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvDetalle_CellValueChanged);
            // 
            // EMPRESA
            // 
            this.EMPRESA.DataPropertyName = "EMPRESA";
            this.EMPRESA.HeaderText = "EMPRESA";
            this.EMPRESA.Name = "EMPRESA";
            this.EMPRESA.Visible = false;
            // 
            // consecutivo
            // 
            this.consecutivo.DataPropertyName = "consecutivo";
            this.consecutivo.HeaderText = "Sec";
            this.consecutivo.Name = "consecutivo";
            this.consecutivo.Width = 50;
            // 
            // HojaRuta
            // 
            this.HojaRuta.DataPropertyName = "HojaRuta";
            this.HojaRuta.HeaderText = "Hoja Ruta";
            this.HojaRuta.Name = "HojaRuta";
            // 
            // SUCURSALCLIENTE
            // 
            this.SUCURSALCLIENTE.DataPropertyName = "SUCURSALCLIENTE";
            this.SUCURSALCLIENTE.HeaderText = "Suc. Cliente";
            this.SUCURSALCLIENTE.Name = "SUCURSALCLIENTE";
            // 
            // CodCliente
            // 
            this.CodCliente.DataPropertyName = "CodCliente";
            this.CodCliente.HeaderText = "Cod. Cliente";
            this.CodCliente.Name = "CodCliente";
            // 
            // nombreCliente
            // 
            this.nombreCliente.DataPropertyName = "nombreCliente";
            this.nombreCliente.HeaderText = "Cliente";
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.Width = 300;
            // 
            // tanque_rep
            // 
            this.tanque_rep.DataPropertyName = "tanque_rep";
            this.tanque_rep.HeaderText = "Cod. Tanque";
            this.tanque_rep.Name = "tanque_rep";
            // 
            // tanquedsc
            // 
            this.tanquedsc.DataPropertyName = "tanquedsc";
            this.tanquedsc.HeaderText = "Tanque";
            this.tanquedsc.Name = "tanquedsc";
            this.tanquedsc.Width = 200;
            // 
            // kmLlegada
            // 
            this.kmLlegada.DataPropertyName = "kmLlegada";
            this.kmLlegada.HeaderText = "Km. Llegada";
            this.kmLlegada.Name = "kmLlegada";
            this.kmLlegada.Width = 80;
            // 
            // KILOMETRAJEDIF
            // 
            this.KILOMETRAJEDIF.DataPropertyName = "KILOMETRAJEDIF";
            this.KILOMETRAJEDIF.HeaderText = "Km. Diferencia";
            this.KILOMETRAJEDIF.Name = "KILOMETRAJEDIF";
            this.KILOMETRAJEDIF.Width = 80;
            // 
            // total
            // 
            this.total.DataPropertyName = "TOTAL";
            this.total.HeaderText = "Total KM";
            this.total.Name = "total";
            // 
            // MODIFICADO
            // 
            this.MODIFICADO.DataPropertyName = "MODIFICADO";
            this.MODIFICADO.HeaderText = "Modificado";
            this.MODIFICADO.Name = "MODIFICADO";
            this.MODIFICADO.ReadOnly = true;
            this.MODIFICADO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MODIFICADO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ORDEN_REP
            // 
            this.ORDEN_REP.HeaderText = "ORDEN_REP";
            this.ORDEN_REP.Name = "ORDEN_REP";
            this.ORDEN_REP.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.btnAprobarHr,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.tsbCancelarAprobacion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1261, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbGuardar.Image = global::FletesLiquidos.Properties.Resources.if_save_1608823;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(149, 22);
            this.tsbGuardar.Text = "Actualizar Kilometros ";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // btnAprobarHr
            // 
            this.btnAprobarHr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAprobarHr.Image = global::FletesLiquidos.Properties.Resources.iconfinder_check_alt_118699;
            this.btnAprobarHr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAprobarHr.Name = "btnAprobarHr";
            this.btnAprobarHr.Size = new System.Drawing.Size(141, 22);
            this.btnAprobarHr.Text = "Aprobar hoja de ruta";
            this.btnAprobarHr.Click += new System.EventHandler(this.btnAprobarHr_Click);
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
            // tsbCancelarAprobacion
            // 
            this.tsbCancelarAprobacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbCancelarAprobacion.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelarAprobacion.Image")));
            this.tsbCancelarAprobacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelarAprobacion.Name = "tsbCancelarAprobacion";
            this.tsbCancelarAprobacion.Size = new System.Drawing.Size(162, 22);
            this.tsbCancelarAprobacion.Text = "Desaprobar Hoja de ruta";
            this.tsbCancelarAprobacion.Click += new System.EventHandler(this.tsbCancelarAprobacion_Click);
            // 
            // FrmDetalleHr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 391);
            this.Controls.Add(this.grvDetalle);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmDetalleHr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle Hr";
            this.Load += new System.EventHandler(this.FrmDetalleHr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvDetalle)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvDetalle;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPRESA;
        private System.Windows.Forms.DataGridViewTextBoxColumn consecutivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HojaRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUCURSALCLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanque_rep;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanquedsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn KILOMETRAJEDIF;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MODIFICADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDEN_REP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAprobarHr;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbCancelarAprobacion;
    }
}