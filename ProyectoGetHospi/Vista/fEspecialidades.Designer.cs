namespace ProyectoGetHospi.Vista
{
    partial class fEspecialidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEspecialidades));
            this.btnRegresar = new System.Windows.Forms.Button();
            this.especialidadesDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEspecialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarEspecialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEspecialidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recargarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).BeginInit();
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
            this.btnRegresar.Location = new System.Drawing.Point(318, 285);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(142, 32);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Volver al menú";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // especialidadesDataGridView
            // 
            this.especialidadesDataGridView.AutoGenerateColumns = false;
            this.especialidadesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.especialidadesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.especialidadesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.especialidadesDataGridView.DataSource = this.especialidadesBindingSource;
            this.especialidadesDataGridView.Location = new System.Drawing.Point(12, 42);
            this.especialidadesDataGridView.Name = "especialidadesDataGridView";
            this.especialidadesDataGridView.Size = new System.Drawing.Size(448, 220);
            this.especialidadesDataGridView.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.recargarDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(474, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEspecialidadToolStripMenuItem,
            this.actualizarEspecialidadToolStripMenuItem,
            this.eliminarEspecialidadToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // registrarEspecialidadToolStripMenuItem
            // 
            this.registrarEspecialidadToolStripMenuItem.Name = "registrarEspecialidadToolStripMenuItem";
            this.registrarEspecialidadToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.registrarEspecialidadToolStripMenuItem.Text = "Nueva Especialidad";
            this.registrarEspecialidadToolStripMenuItem.Click += new System.EventHandler(this.registrarEspecialidadToolStripMenuItem_Click);
            // 
            // actualizarEspecialidadToolStripMenuItem
            // 
            this.actualizarEspecialidadToolStripMenuItem.Name = "actualizarEspecialidadToolStripMenuItem";
            this.actualizarEspecialidadToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.actualizarEspecialidadToolStripMenuItem.Text = "Actualizar Especialidad";
            this.actualizarEspecialidadToolStripMenuItem.Click += new System.EventHandler(this.actualizarEspecialidadToolStripMenuItem_Click);
            // 
            // eliminarEspecialidadToolStripMenuItem
            // 
            this.eliminarEspecialidadToolStripMenuItem.Name = "eliminarEspecialidadToolStripMenuItem";
            this.eliminarEspecialidadToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.eliminarEspecialidadToolStripMenuItem.Text = "Eliminar Especialidad";
            this.eliminarEspecialidadToolStripMenuItem.Click += new System.EventHandler(this.eliminarEspecialidadToolStripMenuItem_Click);
            // 
            // recargarDatosToolStripMenuItem
            // 
            this.recargarDatosToolStripMenuItem.Name = "recargarDatosToolStripMenuItem";
            this.recargarDatosToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.recargarDatosToolStripMenuItem.Text = "Recargar Datos";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idEspecialidad";
            this.dataGridViewTextBoxColumn1.HeaderText = "idEspecialidad";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idMedico";
            this.dataGridViewTextBoxColumn3.HeaderText = "idMedico";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // especialidadesBindingSource
            // 
            this.especialidadesBindingSource.DataSource = typeof(ProyectoGetHospi.Entidades.Especialidades);
            // 
            // fEspecialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(474, 341);
            this.Controls.Add(this.especialidadesDataGridView);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fEspecialidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Especialidades";
            this.Load += new System.EventHandler(this.fEspecialidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEspecialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource especialidadesBindingSource;
        private System.Windows.Forms.DataGridView especialidadesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEspecialidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarEspecialidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarEspecialidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recargarDatosToolStripMenuItem;
    }
}