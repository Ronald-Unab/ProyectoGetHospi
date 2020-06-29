namespace ProyectoGetHospi.Vista
{
    partial class Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.consultasDataGridView = new System.Windows.Forms.DataGridView();
            this.consultasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recargarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(623, 351);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(138, 28);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Volver al menú";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // consultasDataGridView
            // 
            this.consultasDataGridView.AutoGenerateColumns = false;
            this.consultasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.consultasDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            this.consultasDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consultasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultasDataGridView.DataSource = this.consultasBindingSource1;
            this.consultasDataGridView.Location = new System.Drawing.Point(207, 46);
            this.consultasDataGridView.Name = "consultasDataGridView";
            this.consultasDataGridView.Size = new System.Drawing.Size(554, 299);
            this.consultasDataGridView.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.recargarDatosToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(12, 188);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(158, 54);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarConsultaToolStripMenuItem,
            this.actualizarConsultaToolStripMenuItem,
            this.eliminarConsultaToolStripMenuItem});
            this.opcionesToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("opcionesToolStripMenuItem.Image")));
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // registrarConsultaToolStripMenuItem
            // 
            this.registrarConsultaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.registrarConsultaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrarConsultaToolStripMenuItem.Image")));
            this.registrarConsultaToolStripMenuItem.Name = "registrarConsultaToolStripMenuItem";
            this.registrarConsultaToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.registrarConsultaToolStripMenuItem.Text = "Registrar Consulta";
            this.registrarConsultaToolStripMenuItem.Click += new System.EventHandler(this.registrarConsultaToolStripMenuItem_Click);
            // 
            // actualizarConsultaToolStripMenuItem
            // 
            this.actualizarConsultaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.actualizarConsultaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actualizarConsultaToolStripMenuItem.Image")));
            this.actualizarConsultaToolStripMenuItem.Name = "actualizarConsultaToolStripMenuItem";
            this.actualizarConsultaToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.actualizarConsultaToolStripMenuItem.Text = "Actualizar Consulta";
            this.actualizarConsultaToolStripMenuItem.Click += new System.EventHandler(this.actualizarConsultaToolStripMenuItem_Click);
            // 
            // eliminarConsultaToolStripMenuItem
            // 
            this.eliminarConsultaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.eliminarConsultaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarConsultaToolStripMenuItem.Image")));
            this.eliminarConsultaToolStripMenuItem.Name = "eliminarConsultaToolStripMenuItem";
            this.eliminarConsultaToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.eliminarConsultaToolStripMenuItem.Text = "Eliminar Consulta";
            this.eliminarConsultaToolStripMenuItem.Click += new System.EventHandler(this.eliminarConsultaToolStripMenuItem_Click);
            // 
            // recargarDatosToolStripMenuItem
            // 
            this.recargarDatosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recargarDatosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recargarDatosToolStripMenuItem.Image")));
            this.recargarDatosToolStripMenuItem.Name = "recargarDatosToolStripMenuItem";
            this.recargarDatosToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.recargarDatosToolStripMenuItem.Text = "Recargar Datos";
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
            this.panel1.Size = new System.Drawing.Size(180, 400);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 131);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Consultas";
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(783, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.consultasDataGridView);
            this.Controls.Add(this.btnRegresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Consulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.fConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn idConsultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArchivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource consultasBindingSource;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.BindingSource consultasBindingSource1;
        private System.Windows.Forms.DataGridView consultasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recargarDatosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}