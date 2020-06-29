namespace ProyectoGetHospi.Vista
{
    partial class fDiagnosticos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDiagnosticos));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.diagnosticosDataGridView = new System.Windows.Forms.DataGridView();
            this.diagnosticosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoDiagnosticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarDiagnosticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDiagnosticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recargarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.btnRegresar.Location = new System.Drawing.Point(622, 351);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(139, 29);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Volver al menú";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // diagnosticosDataGridView
            // 
            this.diagnosticosDataGridView.AutoGenerateColumns = false;
            this.diagnosticosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.diagnosticosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            this.diagnosticosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diagnosticosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diagnosticosDataGridView.DataSource = this.diagnosticosBindingSource;
            this.diagnosticosDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            this.diagnosticosDataGridView.Location = new System.Drawing.Point(207, 46);
            this.diagnosticosDataGridView.Name = "diagnosticosDataGridView";
            this.diagnosticosDataGridView.Size = new System.Drawing.Size(554, 299);
            this.diagnosticosDataGridView.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.recargarDatosToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(14, 187);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(158, 54);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoDiagnosticoToolStripMenuItem,
            this.actualizarDiagnosticoToolStripMenuItem,
            this.eliminarDiagnosticoToolStripMenuItem});
            this.opcionesToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("opcionesToolStripMenuItem.Image")));
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // nuevoDiagnosticoToolStripMenuItem
            // 
            this.nuevoDiagnosticoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.nuevoDiagnosticoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoDiagnosticoToolStripMenuItem.Image")));
            this.nuevoDiagnosticoToolStripMenuItem.Name = "nuevoDiagnosticoToolStripMenuItem";
            this.nuevoDiagnosticoToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.nuevoDiagnosticoToolStripMenuItem.Text = "Registrar Diagnostico";
            this.nuevoDiagnosticoToolStripMenuItem.Click += new System.EventHandler(this.nuevoDiagnosticoToolStripMenuItem_Click);
            // 
            // actualizarDiagnosticoToolStripMenuItem
            // 
            this.actualizarDiagnosticoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.actualizarDiagnosticoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("actualizarDiagnosticoToolStripMenuItem.Image")));
            this.actualizarDiagnosticoToolStripMenuItem.Name = "actualizarDiagnosticoToolStripMenuItem";
            this.actualizarDiagnosticoToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.actualizarDiagnosticoToolStripMenuItem.Text = "Actualizar Diagnostico";
            this.actualizarDiagnosticoToolStripMenuItem.Click += new System.EventHandler(this.actualizarDiagnosticoToolStripMenuItem_Click);
            // 
            // eliminarDiagnosticoToolStripMenuItem
            // 
            this.eliminarDiagnosticoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.eliminarDiagnosticoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eliminarDiagnosticoToolStripMenuItem.Image")));
            this.eliminarDiagnosticoToolStripMenuItem.Name = "eliminarDiagnosticoToolStripMenuItem";
            this.eliminarDiagnosticoToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.eliminarDiagnosticoToolStripMenuItem.Text = "Eliminar Diagnostico";
            this.eliminarDiagnosticoToolStripMenuItem.Click += new System.EventHandler(this.eliminarDiagnosticoToolStripMenuItem_Click);
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
            this.panel1.Size = new System.Drawing.Size(181, 400);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 133);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Diagnostico";
            // 
            // fDiagnosticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(783, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.diagnosticosDataGridView);
            this.Controls.Add(this.btnRegresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fDiagnosticos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnosticos";
            this.Load += new System.EventHandler(this.fDiagnosticos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn idDiagnosticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recetasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConsultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.BindingSource diagnosticosBindingSource;
        private System.Windows.Forms.DataGridView diagnosticosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoDiagnosticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarDiagnosticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarDiagnosticoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recargarDatosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}