namespace FletesLiquidos
{
    partial class FrmFletesParametrizados
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.grvFletes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VEHICULO_VEH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPRES_TRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_ENTREGA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_TIPOLIQUIDACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALORFIJO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALORKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R_INICIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R_FINAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvFletes)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1106, 25);
            this.toolStrip1.TabIndex = 0;
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
            // grvFletes
            // 
            this.grvFletes.AllowUserToAddRows = false;
            this.grvFletes.AllowUserToDeleteRows = false;
            this.grvFletes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvFletes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.VEHICULO_VEH,
            this.EMPID,
            this.EMPRES_TRA,
            this.TIPO_PRODUCTO,
            this.TIPO_ENTREGA,
            this.ID_TIPOLIQUIDACION,
            this.VALORFIJO,
            this.VALORKM,
            this.R_INICIAL,
            this.R_FINAL});
            this.grvFletes.ContextMenuStrip = this.contextMenuStrip1;
            this.grvFletes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvFletes.Location = new System.Drawing.Point(0, 25);
            this.grvFletes.Name = "grvFletes";
            this.grvFletes.ReadOnly = true;
            this.grvFletes.Size = new System.Drawing.Size(1106, 424);
            this.grvFletes.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // VEHICULO_VEH
            // 
            this.VEHICULO_VEH.DataPropertyName = "VEHICULO_VEH";
            this.VEHICULO_VEH.HeaderText = "VEHICULO_VEH";
            this.VEHICULO_VEH.Name = "VEHICULO_VEH";
            this.VEHICULO_VEH.ReadOnly = true;
            this.VEHICULO_VEH.Visible = false;
            // 
            // EMPID
            // 
            this.EMPID.DataPropertyName = "EMPID";
            this.EMPID.HeaderText = "Empresa";
            this.EMPID.Name = "EMPID";
            this.EMPID.ReadOnly = true;
            this.EMPID.Width = 200;
            // 
            // EMPRES_TRA
            // 
            this.EMPRES_TRA.DataPropertyName = "EMPRES_TRA";
            this.EMPRES_TRA.HeaderText = "Transportadora";
            this.EMPRES_TRA.Name = "EMPRES_TRA";
            this.EMPRES_TRA.ReadOnly = true;
            this.EMPRES_TRA.Width = 150;
            // 
            // TIPO_PRODUCTO
            // 
            this.TIPO_PRODUCTO.DataPropertyName = "TIPO_PRODUCTO";
            this.TIPO_PRODUCTO.HeaderText = "Tipo Prod.";
            this.TIPO_PRODUCTO.Name = "TIPO_PRODUCTO";
            this.TIPO_PRODUCTO.ReadOnly = true;
            // 
            // TIPO_ENTREGA
            // 
            this.TIPO_ENTREGA.DataPropertyName = "TIPO_ENTREGA";
            this.TIPO_ENTREGA.HeaderText = "Tipo Entrega";
            this.TIPO_ENTREGA.Name = "TIPO_ENTREGA";
            this.TIPO_ENTREGA.ReadOnly = true;
            // 
            // ID_TIPOLIQUIDACION
            // 
            this.ID_TIPOLIQUIDACION.DataPropertyName = "ID_TIPOLIQUIDACION";
            this.ID_TIPOLIQUIDACION.HeaderText = "Tipo Liquidacion";
            this.ID_TIPOLIQUIDACION.Name = "ID_TIPOLIQUIDACION";
            this.ID_TIPOLIQUIDACION.ReadOnly = true;
            // 
            // VALORFIJO
            // 
            this.VALORFIJO.DataPropertyName = "VALORFIJO";
            this.VALORFIJO.HeaderText = "Valor Fijo";
            this.VALORFIJO.Name = "VALORFIJO";
            this.VALORFIJO.ReadOnly = true;
            // 
            // VALORKM
            // 
            this.VALORKM.DataPropertyName = "VALORKM";
            this.VALORKM.HeaderText = "Valor Km";
            this.VALORKM.Name = "VALORKM";
            this.VALORKM.ReadOnly = true;
            // 
            // R_INICIAL
            // 
            this.R_INICIAL.DataPropertyName = "R_INICIAL";
            this.R_INICIAL.HeaderText = "Km Inicial";
            this.R_INICIAL.Name = "R_INICIAL";
            this.R_INICIAL.ReadOnly = true;
            // 
            // R_FINAL
            // 
            this.R_FINAL.DataPropertyName = "R_FINAL";
            this.R_FINAL.HeaderText = "Km Final";
            this.R_FINAL.Name = "R_FINAL";
            this.R_FINAL.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 54);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 6);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.modificarToolStripMenuItem.Image = global::FletesLiquidos.Properties.Resources.iconfinder_write_1265821;
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.eliminarToolStripMenuItem.Image = global::FletesLiquidos.Properties.Resources.iconfinder_200_CircledMinus_1833171;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton1.Image = global::FletesLiquidos.Properties.Resources.iconfinder_199_CircledPlus_1833161;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(152, 22);
            this.toolStripButton1.Text = "Agregar Configuracion";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton2.Image = global::FletesLiquidos.Properties.Resources.iconfinder_vehicles_11_8097331;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(208, 22);
            this.toolStripButton2.Text = "Parametrizacion Rutas Promedio";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // FrmFletesParametrizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 449);
            this.Controls.Add(this.grvFletes);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmFletesParametrizados";
            this.Text = "FrmFletesParametrizados";
            this.Load += new System.EventHandler(this.FrmFletesParametrizados_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvFletes)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView grvFletes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VEHICULO_VEH;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPRES_TRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_ENTREGA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_TIPOLIQUIDACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALORFIJO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALORKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn R_INICIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn R_FINAL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}