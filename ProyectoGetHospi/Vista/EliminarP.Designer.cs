namespace ProyectoGetHospi.Vista
{
    partial class EliminarP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarP));
            this.pacientesDataGridView = new System.Windows.Forms.DataGridView();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cédulaPacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direcciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNcimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePadreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMadreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupoSanguineoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pacientesDataGridView
            // 
            this.pacientesDataGridView.AllowUserToAddRows = false;
            this.pacientesDataGridView.AllowUserToDeleteRows = false;
            this.pacientesDataGridView.AutoGenerateColumns = false;
            this.pacientesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pacientesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            this.pacientesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pacientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pacientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cédulaPacienteDataGridViewTextBoxColumn,
            this.numRegistroDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direcciónDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.fechaNcimientoDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.nombrePadreDataGridViewTextBoxColumn,
            this.nombreMadreDataGridViewTextBoxColumn,
            this.grupoSanguineoDataGridViewTextBoxColumn});
            this.pacientesDataGridView.DataSource = this.pacientesBindingSource;
            this.pacientesDataGridView.Location = new System.Drawing.Point(41, 48);
            this.pacientesDataGridView.Name = "pacientesDataGridView";
            this.pacientesDataGridView.ReadOnly = true;
            this.pacientesDataGridView.Size = new System.Drawing.Size(575, 212);
            this.pacientesDataGridView.TabIndex = 1;
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnEliminarP.FlatAppearance.BorderSize = 0;
            this.btnEliminarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarP.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarP.Image")));
            this.btnEliminarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarP.Location = new System.Drawing.Point(434, 276);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(182, 29);
            this.btnEliminarP.TabIndex = 2;
            this.btnEliminarP.Text = "Eliminar Seleccionado";
            this.btnEliminarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarP.UseVisualStyleBackColor = false;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminarP_Click);
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataSource = typeof(ProyectoGetHospi.Entidades.Pacientes);
            // 
            // cédulaPacienteDataGridViewTextBoxColumn
            // 
            this.cédulaPacienteDataGridViewTextBoxColumn.DataPropertyName = "CédulaPaciente";
            this.cédulaPacienteDataGridViewTextBoxColumn.HeaderText = "CédulaPaciente";
            this.cédulaPacienteDataGridViewTextBoxColumn.Name = "cédulaPacienteDataGridViewTextBoxColumn";
            this.cédulaPacienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numRegistroDataGridViewTextBoxColumn
            // 
            this.numRegistroDataGridViewTextBoxColumn.DataPropertyName = "NumRegistro";
            this.numRegistroDataGridViewTextBoxColumn.HeaderText = "NumRegistro";
            this.numRegistroDataGridViewTextBoxColumn.Name = "numRegistroDataGridViewTextBoxColumn";
            this.numRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direcciónDataGridViewTextBoxColumn
            // 
            this.direcciónDataGridViewTextBoxColumn.DataPropertyName = "Dirección";
            this.direcciónDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direcciónDataGridViewTextBoxColumn.Name = "direcciónDataGridViewTextBoxColumn";
            this.direcciónDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNcimientoDataGridViewTextBoxColumn
            // 
            this.fechaNcimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNcimiento";
            this.fechaNcimientoDataGridViewTextBoxColumn.HeaderText = "FechaNcimiento";
            this.fechaNcimientoDataGridViewTextBoxColumn.Name = "fechaNcimientoDataGridViewTextBoxColumn";
            this.fechaNcimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "Sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrePadreDataGridViewTextBoxColumn
            // 
            this.nombrePadreDataGridViewTextBoxColumn.DataPropertyName = "NombrePadre";
            this.nombrePadreDataGridViewTextBoxColumn.HeaderText = "NombrePadre";
            this.nombrePadreDataGridViewTextBoxColumn.Name = "nombrePadreDataGridViewTextBoxColumn";
            this.nombrePadreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreMadreDataGridViewTextBoxColumn
            // 
            this.nombreMadreDataGridViewTextBoxColumn.DataPropertyName = "NombreMadre";
            this.nombreMadreDataGridViewTextBoxColumn.HeaderText = "NombreMadre";
            this.nombreMadreDataGridViewTextBoxColumn.Name = "nombreMadreDataGridViewTextBoxColumn";
            this.nombreMadreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grupoSanguineoDataGridViewTextBoxColumn
            // 
            this.grupoSanguineoDataGridViewTextBoxColumn.DataPropertyName = "GrupoSanguineo";
            this.grupoSanguineoDataGridViewTextBoxColumn.HeaderText = "GrupoSanguineo";
            this.grupoSanguineoDataGridViewTextBoxColumn.Name = "grupoSanguineoDataGridViewTextBoxColumn";
            this.grupoSanguineoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EliminarP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(653, 326);
            this.Controls.Add(this.btnEliminarP);
            this.Controls.Add(this.pacientesDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "EliminarP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar";
            this.Load += new System.EventHandler(this.EliminarP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacientesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView pacientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cédulaPacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direcciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNcimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePadreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMadreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoSanguineoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
    }
}