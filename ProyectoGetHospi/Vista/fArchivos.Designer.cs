namespace ProyectoGetHospi.Vista
{
    partial class fArchivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fArchivos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recargarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.archivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.archivoDataGridView = new System.Windows.Forms.DataGridView();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.recargarDatosToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(13, 185);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(158, 74);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevoToolStripMenuItem,
            this.actualizarArchivoToolStripMenuItem,
            this.eliminarArchivoToolStripMenuItem});
            this.opcionesToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("opcionesToolStripMenuItem.Image")));
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(151, 25);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // registrarNuevoToolStripMenuItem
            // 
            this.registrarNuevoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.registrarNuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrarNuevoToolStripMenuItem.Image")));
            this.registrarNuevoToolStripMenuItem.Name = "registrarNuevoToolStripMenuItem";
            this.registrarNuevoToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.registrarNuevoToolStripMenuItem.Text = "Registrar Archivo";
            this.registrarNuevoToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoToolStripMenuItem_Click);
            // 
            // actualizarArchivoToolStripMenuItem
            // 
            this.actualizarArchivoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.actualizarArchivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actualizarArchivoToolStripMenuItem.Image")));
            this.actualizarArchivoToolStripMenuItem.Name = "actualizarArchivoToolStripMenuItem";
            this.actualizarArchivoToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.actualizarArchivoToolStripMenuItem.Text = "Actualizar Archivo";
            this.actualizarArchivoToolStripMenuItem.Click += new System.EventHandler(this.actualizarArchivoToolStripMenuItem_Click);
            // 
            // eliminarArchivoToolStripMenuItem
            // 
            this.eliminarArchivoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.eliminarArchivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarArchivoToolStripMenuItem.Image")));
            this.eliminarArchivoToolStripMenuItem.Name = "eliminarArchivoToolStripMenuItem";
            this.eliminarArchivoToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.eliminarArchivoToolStripMenuItem.Text = "Eliminar Archivo";
            this.eliminarArchivoToolStripMenuItem.Click += new System.EventHandler(this.eliminarArchivoToolStripMenuItem_Click);
            // 
            // recargarDatosToolStripMenuItem
            // 
            this.recargarDatosToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recargarDatosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recargarDatosToolStripMenuItem.Image")));
            this.recargarDatosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recargarDatosToolStripMenuItem.Name = "recargarDatosToolStripMenuItem";
            this.recargarDatosToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.recargarDatosToolStripMenuItem.Text = "Recargar Datos";
            this.recargarDatosToolStripMenuItem.Click += new System.EventHandler(this.recargarDatosToolStripMenuItem_Click_1);
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
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Archivos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // archivoDataGridView
            // 
            this.archivoDataGridView.AutoGenerateColumns = false;
            this.archivoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.archivoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            this.archivoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.archivoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archivoDataGridView.DataSource = this.archivoBindingSource;
            this.archivoDataGridView.Location = new System.Drawing.Point(207, 46);
            this.archivoDataGridView.Name = "archivoDataGridView";
            this.archivoDataGridView.Size = new System.Drawing.Size(554, 299);
            this.archivoDataGridView.TabIndex = 3;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegresar.Location = new System.Drawing.Point(623, 360);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(138, 28);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Volver al menú";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // fArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(783, 400);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.archivoDataGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fArchivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archivos";
            this.Load += new System.EventHandler(this.fArchivos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn idArchivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn presionArterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperaturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArchivoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem recargarDatosToolStripMenuItem;
        private System.Windows.Forms.BindingSource archivoBindingSource;
        private System.Windows.Forms.DataGridView archivoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnRegresar;
    }
}