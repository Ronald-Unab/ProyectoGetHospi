namespace ProyectoGetHospi
{
    partial class fMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMedico));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarMedicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMedicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAlMenuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recargarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicoDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.médicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idMedicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaMedicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.médicoDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.médicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.recargarDatosToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(7, 187);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(167, 56);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevoToolStripMenuItem,
            this.actualizarMedicoToolStripMenuItem,
            this.eliminarMedicoToolStripMenuItem,
            this.cambiarDeUsuarioToolStripMenuItem,
            this.volverAlMenuPrincipalToolStripMenuItem});
            this.opcionesToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("opcionesToolStripMenuItem.Image")));
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(160, 25);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            this.opcionesToolStripMenuItem.Click += new System.EventHandler(this.opcionesToolStripMenuItem_Click);
            // 
            // registrarNuevoToolStripMenuItem
            // 
            this.registrarNuevoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.registrarNuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrarNuevoToolStripMenuItem.Image")));
            this.registrarNuevoToolStripMenuItem.Name = "registrarNuevoToolStripMenuItem";
            this.registrarNuevoToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.registrarNuevoToolStripMenuItem.Text = "Registrar Nuevo";
            this.registrarNuevoToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoToolStripMenuItem_Click);
            // 
            // actualizarMedicoToolStripMenuItem
            // 
            this.actualizarMedicoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.actualizarMedicoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actualizarMedicoToolStripMenuItem.Image")));
            this.actualizarMedicoToolStripMenuItem.Name = "actualizarMedicoToolStripMenuItem";
            this.actualizarMedicoToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.actualizarMedicoToolStripMenuItem.Text = "Actualizar Medico";
            this.actualizarMedicoToolStripMenuItem.Click += new System.EventHandler(this.actualizarMedicoToolStripMenuItem_Click);
            // 
            // eliminarMedicoToolStripMenuItem
            // 
            this.eliminarMedicoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.eliminarMedicoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarMedicoToolStripMenuItem.Image")));
            this.eliminarMedicoToolStripMenuItem.Name = "eliminarMedicoToolStripMenuItem";
            this.eliminarMedicoToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.eliminarMedicoToolStripMenuItem.Text = "Eliminar Medico";
            this.eliminarMedicoToolStripMenuItem.Click += new System.EventHandler(this.eliminarMedicoToolStripMenuItem_Click);
            // 
            // cambiarDeUsuarioToolStripMenuItem
            // 
            this.cambiarDeUsuarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.cambiarDeUsuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cambiarDeUsuarioToolStripMenuItem.Image")));
            this.cambiarDeUsuarioToolStripMenuItem.Name = "cambiarDeUsuarioToolStripMenuItem";
            this.cambiarDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.cambiarDeUsuarioToolStripMenuItem.Text = "Cambiar de Usuario";
            // 
            // volverAlMenuPrincipalToolStripMenuItem
            // 
            this.volverAlMenuPrincipalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.volverAlMenuPrincipalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("volverAlMenuPrincipalToolStripMenuItem.Image")));
            this.volverAlMenuPrincipalToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.volverAlMenuPrincipalToolStripMenuItem.Name = "volverAlMenuPrincipalToolStripMenuItem";
            this.volverAlMenuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.volverAlMenuPrincipalToolStripMenuItem.Text = "Volver ";
            this.volverAlMenuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.volverAlMenuPrincipalToolStripMenuItem_Click);
            // 
            // recargarDatosToolStripMenuItem
            // 
            this.recargarDatosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recargarDatosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recargarDatosToolStripMenuItem.Image")));
            this.recargarDatosToolStripMenuItem.Name = "recargarDatosToolStripMenuItem";
            this.recargarDatosToolStripMenuItem.Size = new System.Drawing.Size(160, 25);
            this.recargarDatosToolStripMenuItem.Text = "Recargar Datos";
            this.recargarDatosToolStripMenuItem.Click += new System.EventHandler(this.recargarDatosToolStripMenuItem_Click);
            // 
            // médicoDataGridView
            // 
            this.médicoDataGridView.AllowUserToAddRows = false;
            this.médicoDataGridView.AllowUserToDeleteRows = false;
            this.médicoDataGridView.AutoGenerateColumns = false;
            this.médicoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.médicoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            this.médicoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.médicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.médicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMedicoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.dUIDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.cedulaMedicoDataGridViewTextBoxColumn});
            this.médicoDataGridView.DataSource = this.médicoBindingSource;
            this.médicoDataGridView.Location = new System.Drawing.Point(186, 14);
            this.médicoDataGridView.Name = "médicoDataGridView";
            this.médicoDataGridView.ReadOnly = true;
            this.médicoDataGridView.Size = new System.Drawing.Size(696, 466);
            this.médicoDataGridView.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 492);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Médicos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // médicoBindingSource
            // 
            //this.médicoBindingSource.DataSource = typeof(ProyectoGetHospi.Entidades.Médico);
            // 
            // idMedicoDataGridViewTextBoxColumn
            // 
            this.idMedicoDataGridViewTextBoxColumn.DataPropertyName = "IdMedico";
            this.idMedicoDataGridViewTextBoxColumn.HeaderText = "IdMedico";
            this.idMedicoDataGridViewTextBoxColumn.Name = "idMedicoDataGridViewTextBoxColumn";
            this.idMedicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dUIDataGridViewTextBoxColumn
            // 
            this.dUIDataGridViewTextBoxColumn.DataPropertyName = "DUI";
            this.dUIDataGridViewTextBoxColumn.HeaderText = "DUI";
            this.dUIDataGridViewTextBoxColumn.Name = "dUIDataGridViewTextBoxColumn";
            this.dUIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cedulaMedicoDataGridViewTextBoxColumn
            // 
            this.cedulaMedicoDataGridViewTextBoxColumn.DataPropertyName = "CedulaMedico";
            this.cedulaMedicoDataGridViewTextBoxColumn.HeaderText = "CedulaMedico";
            this.cedulaMedicoDataGridViewTextBoxColumn.Name = "cedulaMedicoDataGridViewTextBoxColumn";
            this.cedulaMedicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(894, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.médicoDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.médicoDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.médicoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarMedicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarMedicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAlMenuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recargarDatosToolStripMenuItem;
        private System.Windows.Forms.DataGridView médicoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem cambiarDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaMedicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource médicoBindingSource;
    }
}

