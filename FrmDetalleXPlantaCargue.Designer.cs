namespace FletesLiquidos
{
    partial class FrmDetalleXPlantaCargue
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
            this.grvDetalle = new System.Windows.Forms.DataGridView();
            this.HOJARUTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRECLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADICIONAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.verAdicionalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetalle)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvDetalle
            // 
            this.grvDetalle.AllowUserToAddRows = false;
            this.grvDetalle.AllowUserToDeleteRows = false;
            this.grvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HOJARUTA,
            this.NOMBRECLIENTE,
            this.ADICIONAL,
            this.token});
            this.grvDetalle.ContextMenuStrip = this.contextMenuStrip1;
            this.grvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvDetalle.Location = new System.Drawing.Point(0, 0);
            this.grvDetalle.Name = "grvDetalle";
            this.grvDetalle.ReadOnly = true;
            this.grvDetalle.Size = new System.Drawing.Size(626, 348);
            this.grvDetalle.TabIndex = 0;
            // 
            // HOJARUTA
            // 
            this.HOJARUTA.DataPropertyName = "HOJARUTA";
            this.HOJARUTA.HeaderText = "Hoja Ruta";
            this.HOJARUTA.Name = "HOJARUTA";
            this.HOJARUTA.ReadOnly = true;
            // 
            // NOMBRECLIENTE
            // 
            this.NOMBRECLIENTE.DataPropertyName = "NOMBRECLIENTE";
            this.NOMBRECLIENTE.HeaderText = "Planta Cargue";
            this.NOMBRECLIENTE.Name = "NOMBRECLIENTE";
            this.NOMBRECLIENTE.ReadOnly = true;
            this.NOMBRECLIENTE.Width = 200;
            // 
            // ADICIONAL
            // 
            this.ADICIONAL.DataPropertyName = "ADICIONAL";
            this.ADICIONAL.HeaderText = "Valor Adicional";
            this.ADICIONAL.Name = "ADICIONAL";
            this.ADICIONAL.ReadOnly = true;
            // 
            // token
            // 
            this.token.DataPropertyName = "token";
            this.token.HeaderText = "token";
            this.token.Name = "token";
            this.token.ReadOnly = true;
            this.token.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verAdicionalesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 26);
            // 
            // verAdicionalesToolStripMenuItem
            // 
            this.verAdicionalesToolStripMenuItem.Image = global::FletesLiquidos.Properties.Resources.if_11_Search_106236;
            this.verAdicionalesToolStripMenuItem.Name = "verAdicionalesToolStripMenuItem";
            this.verAdicionalesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verAdicionalesToolStripMenuItem.Text = "Ver Adicionales";
            this.verAdicionalesToolStripMenuItem.Click += new System.EventHandler(this.verAdicionalesToolStripMenuItem_Click);
            // 
            // FrmDetalleXPlantaCargue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 348);
            this.Controls.Add(this.grvDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmDetalleXPlantaCargue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "hojas de ruta que generan Adicionales";
            this.Load += new System.EventHandler(this.FrmDetalleXPlantaCargue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvDetalle)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOJARUTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRECLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADICIONAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn token;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verAdicionalesToolStripMenuItem;
    }
}