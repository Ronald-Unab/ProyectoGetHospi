namespace ProyectoGetHospi.Vista
{
    partial class ActualizarP
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
            System.Windows.Forms.Label cédulaPacienteLabel;
            System.Windows.Forms.Label direcciónLabel;
            System.Windows.Forms.Label fechaNcimientoLabel;
            System.Windows.Forms.Label grupoSanguineoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label nombreMadreLabel;
            System.Windows.Forms.Label nombrePadreLabel;
            System.Windows.Forms.Label numRegistroLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label telefonoLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnGuardarP = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cédulaPacienteTextBox = new System.Windows.Forms.TextBox();
            this.direcciónTextBox = new System.Windows.Forms.TextBox();
            this.fechaNcimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.grupoSanguineoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.nombreMadreTextBox = new System.Windows.Forms.TextBox();
            this.nombrePadreTextBox = new System.Windows.Forms.TextBox();
            this.numRegistroTextBox = new System.Windows.Forms.TextBox();
            this.sexoTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            cédulaPacienteLabel = new System.Windows.Forms.Label();
            direcciónLabel = new System.Windows.Forms.Label();
            fechaNcimientoLabel = new System.Windows.Forms.Label();
            grupoSanguineoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            nombreMadreLabel = new System.Windows.Forms.Label();
            nombrePadreLabel = new System.Windows.Forms.Label();
            numRegistroLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(cédulaPacienteLabel);
            this.groupBox1.Controls.Add(this.cédulaPacienteTextBox);
            this.groupBox1.Controls.Add(direcciónLabel);
            this.groupBox1.Controls.Add(this.direcciónTextBox);
            this.groupBox1.Controls.Add(fechaNcimientoLabel);
            this.groupBox1.Controls.Add(this.fechaNcimientoDateTimePicker);
            this.groupBox1.Controls.Add(grupoSanguineoLabel);
            this.groupBox1.Controls.Add(this.grupoSanguineoTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(nombreMadreLabel);
            this.groupBox1.Controls.Add(this.nombreMadreTextBox);
            this.groupBox1.Controls.Add(nombrePadreLabel);
            this.groupBox1.Controls.Add(this.nombrePadreTextBox);
            this.groupBox1.Controls.Add(numRegistroLabel);
            this.groupBox1.Controls.Add(this.numRegistroTextBox);
            this.groupBox1.Controls.Add(sexoLabel);
            this.groupBox1.Controls.Add(this.sexoTextBox);
            this.groupBox1.Controls.Add(telefonoLabel);
            this.groupBox1.Controls.Add(this.telefonoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(483, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 299);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(559, 379);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnGuardarP
            // 
            this.btnGuardarP.Location = new System.Drawing.Point(640, 379);
            this.btnGuardarP.Name = "btnGuardarP";
            this.btnGuardarP.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarP.TabIndex = 4;
            this.btnGuardarP.Text = "Guardar";
            this.btnGuardarP.UseVisualStyleBackColor = true;
            this.btnGuardarP.Click += new System.EventHandler(this.btnGuardarP_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.AutoGenerateColumns = false;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPaciente,
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
            this.dgvPacientes.DataSource = this.pacientesBindingSource;
            this.dgvPacientes.Location = new System.Drawing.Point(12, 91);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.Size = new System.Drawing.Size(445, 322);
            this.dgvPacientes.TabIndex = 4;
            // 
            // IdPaciente
            // 
            this.IdPaciente.DataPropertyName = "IdPaciente";
            this.IdPaciente.HeaderText = "IdPaciente";
            this.IdPaciente.Name = "IdPaciente";
            this.IdPaciente.ReadOnly = true;
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
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataSource = typeof(ProyectoGetHospi.Entidades.Pacientes);
            // 
            // cédulaPacienteLabel
            // 
            cédulaPacienteLabel.AutoSize = true;
            cédulaPacienteLabel.Location = new System.Drawing.Point(17, 35);
            cédulaPacienteLabel.Name = "cédulaPacienteLabel";
            cédulaPacienteLabel.Size = new System.Drawing.Size(88, 13);
            cédulaPacienteLabel.TabIndex = 0;
            cédulaPacienteLabel.Text = "Cédula Paciente:";
            // 
            // cédulaPacienteTextBox
            // 
            this.cédulaPacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "CédulaPaciente", true));
            this.cédulaPacienteTextBox.Location = new System.Drawing.Point(116, 32);
            this.cédulaPacienteTextBox.Name = "cédulaPacienteTextBox";
            this.cédulaPacienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.cédulaPacienteTextBox.TabIndex = 1;
            // 
            // direcciónLabel
            // 
            direcciónLabel.AutoSize = true;
            direcciónLabel.Location = new System.Drawing.Point(17, 61);
            direcciónLabel.Name = "direcciónLabel";
            direcciónLabel.Size = new System.Drawing.Size(55, 13);
            direcciónLabel.TabIndex = 2;
            direcciónLabel.Text = "Dirección:";
            // 
            // direcciónTextBox
            // 
            this.direcciónTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Dirección", true));
            this.direcciónTextBox.Location = new System.Drawing.Point(116, 58);
            this.direcciónTextBox.Name = "direcciónTextBox";
            this.direcciónTextBox.Size = new System.Drawing.Size(200, 20);
            this.direcciónTextBox.TabIndex = 3;
            // 
            // fechaNcimientoLabel
            // 
            fechaNcimientoLabel.AutoSize = true;
            fechaNcimientoLabel.Location = new System.Drawing.Point(17, 88);
            fechaNcimientoLabel.Name = "fechaNcimientoLabel";
            fechaNcimientoLabel.Size = new System.Drawing.Size(90, 13);
            fechaNcimientoLabel.TabIndex = 4;
            fechaNcimientoLabel.Text = "Fecha Ncimiento:";
            // 
            // fechaNcimientoDateTimePicker
            // 
            this.fechaNcimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pacientesBindingSource, "FechaNcimiento", true));
            this.fechaNcimientoDateTimePicker.Location = new System.Drawing.Point(116, 84);
            this.fechaNcimientoDateTimePicker.Name = "fechaNcimientoDateTimePicker";
            this.fechaNcimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNcimientoDateTimePicker.TabIndex = 5;
            // 
            // grupoSanguineoLabel
            // 
            grupoSanguineoLabel.AutoSize = true;
            grupoSanguineoLabel.Location = new System.Drawing.Point(17, 113);
            grupoSanguineoLabel.Name = "grupoSanguineoLabel";
            grupoSanguineoLabel.Size = new System.Drawing.Size(93, 13);
            grupoSanguineoLabel.TabIndex = 6;
            grupoSanguineoLabel.Text = "Grupo Sanguineo:";
            // 
            // grupoSanguineoTextBox
            // 
            this.grupoSanguineoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "GrupoSanguineo", true));
            this.grupoSanguineoTextBox.Location = new System.Drawing.Point(116, 110);
            this.grupoSanguineoTextBox.Name = "grupoSanguineoTextBox";
            this.grupoSanguineoTextBox.Size = new System.Drawing.Size(200, 20);
            this.grupoSanguineoTextBox.TabIndex = 7;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(17, 140);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 10;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(116, 137);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 11;
            // 
            // nombreMadreLabel
            // 
            nombreMadreLabel.AutoSize = true;
            nombreMadreLabel.Location = new System.Drawing.Point(17, 166);
            nombreMadreLabel.Name = "nombreMadreLabel";
            nombreMadreLabel.Size = new System.Drawing.Size(80, 13);
            nombreMadreLabel.TabIndex = 12;
            nombreMadreLabel.Text = "Nombre Madre:";
            // 
            // nombreMadreTextBox
            // 
            this.nombreMadreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "NombreMadre", true));
            this.nombreMadreTextBox.Location = new System.Drawing.Point(116, 163);
            this.nombreMadreTextBox.Name = "nombreMadreTextBox";
            this.nombreMadreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreMadreTextBox.TabIndex = 13;
            // 
            // nombrePadreLabel
            // 
            nombrePadreLabel.AutoSize = true;
            nombrePadreLabel.Location = new System.Drawing.Point(17, 192);
            nombrePadreLabel.Name = "nombrePadreLabel";
            nombrePadreLabel.Size = new System.Drawing.Size(78, 13);
            nombrePadreLabel.TabIndex = 14;
            nombrePadreLabel.Text = "Nombre Padre:";
            // 
            // nombrePadreTextBox
            // 
            this.nombrePadreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "NombrePadre", true));
            this.nombrePadreTextBox.Location = new System.Drawing.Point(116, 189);
            this.nombrePadreTextBox.Name = "nombrePadreTextBox";
            this.nombrePadreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombrePadreTextBox.TabIndex = 15;
            // 
            // numRegistroLabel
            // 
            numRegistroLabel.AutoSize = true;
            numRegistroLabel.Location = new System.Drawing.Point(17, 218);
            numRegistroLabel.Name = "numRegistroLabel";
            numRegistroLabel.Size = new System.Drawing.Size(74, 13);
            numRegistroLabel.TabIndex = 16;
            numRegistroLabel.Text = "Num Registro:";
            // 
            // numRegistroTextBox
            // 
            this.numRegistroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "NumRegistro", true));
            this.numRegistroTextBox.Location = new System.Drawing.Point(116, 215);
            this.numRegistroTextBox.Name = "numRegistroTextBox";
            this.numRegistroTextBox.Size = new System.Drawing.Size(200, 20);
            this.numRegistroTextBox.TabIndex = 17;
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(17, 244);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(34, 13);
            sexoLabel.TabIndex = 18;
            sexoLabel.Text = "Sexo:";
            // 
            // sexoTextBox
            // 
            this.sexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Sexo", true));
            this.sexoTextBox.Location = new System.Drawing.Point(116, 241);
            this.sexoTextBox.Name = "sexoTextBox";
            this.sexoTextBox.Size = new System.Drawing.Size(200, 20);
            this.sexoTextBox.TabIndex = 19;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(17, 270);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 20;
            telefonoLabel.Text = "Telefono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(116, 267);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefonoTextBox.TabIndex = 21;
            // 
            // ActualizarP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 462);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.btnGuardarP);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.groupBox1);
            this.Name = "ActualizarP";
            this.Text = "Actualizar";
            this.Load += new System.EventHandler(this.ActualizarP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnGuardarP;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPaciente;
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
        private System.Windows.Forms.TextBox cédulaPacienteTextBox;
        private System.Windows.Forms.TextBox direcciónTextBox;
        private System.Windows.Forms.DateTimePicker fechaNcimientoDateTimePicker;
        private System.Windows.Forms.TextBox grupoSanguineoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox nombreMadreTextBox;
        private System.Windows.Forms.TextBox nombrePadreTextBox;
        private System.Windows.Forms.TextBox numRegistroTextBox;
        private System.Windows.Forms.TextBox sexoTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
    }
}