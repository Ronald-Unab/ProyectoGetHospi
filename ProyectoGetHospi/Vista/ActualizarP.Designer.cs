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
            this.cédulaPacienteTextBox = new System.Windows.Forms.TextBox();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.direcciónTextBox = new System.Windows.Forms.TextBox();
            this.fechaNcimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.grupoSanguineoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.nombreMadreTextBox = new System.Windows.Forms.TextBox();
            this.nombrePadreTextBox = new System.Windows.Forms.TextBox();
            this.numRegistroTextBox = new System.Windows.Forms.TextBox();
            this.sexoTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnGuardarP = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.IdPaciente = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // cédulaPacienteLabel
            // 
            cédulaPacienteLabel.AutoSize = true;
            cédulaPacienteLabel.Location = new System.Drawing.Point(12, 16);
            cédulaPacienteLabel.Name = "cédulaPacienteLabel";
            cédulaPacienteLabel.Size = new System.Drawing.Size(88, 13);
            cédulaPacienteLabel.TabIndex = 0;
            cédulaPacienteLabel.Text = "Cédula Paciente:";
            // 
            // direcciónLabel
            // 
            direcciónLabel.AutoSize = true;
            direcciónLabel.Location = new System.Drawing.Point(12, 42);
            direcciónLabel.Name = "direcciónLabel";
            direcciónLabel.Size = new System.Drawing.Size(55, 13);
            direcciónLabel.TabIndex = 2;
            direcciónLabel.Text = "Dirección:";
            // 
            // fechaNcimientoLabel
            // 
            fechaNcimientoLabel.AutoSize = true;
            fechaNcimientoLabel.Location = new System.Drawing.Point(12, 69);
            fechaNcimientoLabel.Name = "fechaNcimientoLabel";
            fechaNcimientoLabel.Size = new System.Drawing.Size(90, 13);
            fechaNcimientoLabel.TabIndex = 4;
            fechaNcimientoLabel.Text = "Fecha Ncimiento:";
            // 
            // grupoSanguineoLabel
            // 
            grupoSanguineoLabel.AutoSize = true;
            grupoSanguineoLabel.Location = new System.Drawing.Point(12, 94);
            grupoSanguineoLabel.Name = "grupoSanguineoLabel";
            grupoSanguineoLabel.Size = new System.Drawing.Size(93, 13);
            grupoSanguineoLabel.TabIndex = 6;
            grupoSanguineoLabel.Text = "Grupo Sanguineo:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(12, 146);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 10;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreMadreLabel
            // 
            nombreMadreLabel.AutoSize = true;
            nombreMadreLabel.Location = new System.Drawing.Point(12, 172);
            nombreMadreLabel.Name = "nombreMadreLabel";
            nombreMadreLabel.Size = new System.Drawing.Size(80, 13);
            nombreMadreLabel.TabIndex = 12;
            nombreMadreLabel.Text = "Nombre Madre:";
            // 
            // nombrePadreLabel
            // 
            nombrePadreLabel.AutoSize = true;
            nombrePadreLabel.Location = new System.Drawing.Point(12, 198);
            nombrePadreLabel.Name = "nombrePadreLabel";
            nombrePadreLabel.Size = new System.Drawing.Size(78, 13);
            nombrePadreLabel.TabIndex = 14;
            nombrePadreLabel.Text = "Nombre Padre:";
            // 
            // numRegistroLabel
            // 
            numRegistroLabel.AutoSize = true;
            numRegistroLabel.Location = new System.Drawing.Point(12, 224);
            numRegistroLabel.Name = "numRegistroLabel";
            numRegistroLabel.Size = new System.Drawing.Size(74, 13);
            numRegistroLabel.TabIndex = 16;
            numRegistroLabel.Text = "Num Registro:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(12, 250);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(34, 13);
            sexoLabel.TabIndex = 18;
            sexoLabel.Text = "Sexo:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(12, 120);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 20;
            telefonoLabel.Text = "Telefono:";
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
            this.groupBox1.Size = new System.Drawing.Size(334, 300);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cédulaPacienteTextBox
            // 
            this.cédulaPacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "CédulaPaciente", true));
            this.cédulaPacienteTextBox.Location = new System.Drawing.Point(111, 13);
            this.cédulaPacienteTextBox.Name = "cédulaPacienteTextBox";
            this.cédulaPacienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.cédulaPacienteTextBox.TabIndex = 1;
            // 
            // direcciónTextBox
            // 
            this.direcciónTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Dirección", true));
            this.direcciónTextBox.Location = new System.Drawing.Point(111, 39);
            this.direcciónTextBox.Name = "direcciónTextBox";
            this.direcciónTextBox.Size = new System.Drawing.Size(200, 20);
            this.direcciónTextBox.TabIndex = 3;
            // 
            // fechaNcimientoDateTimePicker
            // 
            this.fechaNcimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pacientesBindingSource, "FechaNcimiento", true));
            this.fechaNcimientoDateTimePicker.Location = new System.Drawing.Point(111, 65);
            this.fechaNcimientoDateTimePicker.Name = "fechaNcimientoDateTimePicker";
            this.fechaNcimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNcimientoDateTimePicker.TabIndex = 5;
            // 
            // grupoSanguineoTextBox
            // 
            this.grupoSanguineoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "GrupoSanguineo", true));
            this.grupoSanguineoTextBox.Location = new System.Drawing.Point(111, 91);
            this.grupoSanguineoTextBox.Name = "grupoSanguineoTextBox";
            this.grupoSanguineoTextBox.Size = new System.Drawing.Size(200, 20);
            this.grupoSanguineoTextBox.TabIndex = 7;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(111, 143);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 11;
            // 
            // nombreMadreTextBox
            // 
            this.nombreMadreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "NombreMadre", true));
            this.nombreMadreTextBox.Location = new System.Drawing.Point(111, 169);
            this.nombreMadreTextBox.Name = "nombreMadreTextBox";
            this.nombreMadreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreMadreTextBox.TabIndex = 13;
            // 
            // nombrePadreTextBox
            // 
            this.nombrePadreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "NombrePadre", true));
            this.nombrePadreTextBox.Location = new System.Drawing.Point(111, 195);
            this.nombrePadreTextBox.Name = "nombrePadreTextBox";
            this.nombrePadreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombrePadreTextBox.TabIndex = 15;
            // 
            // numRegistroTextBox
            // 
            this.numRegistroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "NumRegistro", true));
            this.numRegistroTextBox.Location = new System.Drawing.Point(111, 221);
            this.numRegistroTextBox.Name = "numRegistroTextBox";
            this.numRegistroTextBox.Size = new System.Drawing.Size(200, 20);
            this.numRegistroTextBox.TabIndex = 17;
            // 
            // sexoTextBox
            // 
            this.sexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Sexo", true));
            this.sexoTextBox.Location = new System.Drawing.Point(111, 247);
            this.sexoTextBox.Name = "sexoTextBox";
            this.sexoTextBox.Size = new System.Drawing.Size(200, 20);
            this.sexoTextBox.TabIndex = 19;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(111, 117);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefonoTextBox.TabIndex = 21;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(559, 419);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnGuardarP
            // 
            this.btnGuardarP.Location = new System.Drawing.Point(640, 419);
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
            this.IdPaciente});
            this.dgvPacientes.DataSource = this.pacientesBindingSource;
            this.dgvPacientes.Location = new System.Drawing.Point(22, 37);
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
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnGuardarP;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.TextBox cédulaPacienteTextBox;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private System.Windows.Forms.TextBox direcciónTextBox;
        private System.Windows.Forms.DateTimePicker fechaNcimientoDateTimePicker;
        private System.Windows.Forms.TextBox grupoSanguineoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox nombreMadreTextBox;
        private System.Windows.Forms.TextBox nombrePadreTextBox;
        private System.Windows.Forms.TextBox numRegistroTextBox;
        private System.Windows.Forms.TextBox sexoTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
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
    }
}