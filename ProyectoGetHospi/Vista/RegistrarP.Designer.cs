﻿namespace ProyectoGetHospi.Vista
{
    partial class RegistrarP
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
            this.grbRegistrarP = new System.Windows.Forms.GroupBox();
            this.btnGuardarP = new System.Windows.Forms.Button();
            this.btnNuevoP = new System.Windows.Forms.Button();
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
            this.grbRegistrarP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbRegistrarP
            // 
            this.grbRegistrarP.Controls.Add(cédulaPacienteLabel);
            this.grbRegistrarP.Controls.Add(this.cédulaPacienteTextBox);
            this.grbRegistrarP.Controls.Add(direcciónLabel);
            this.grbRegistrarP.Controls.Add(this.direcciónTextBox);
            this.grbRegistrarP.Controls.Add(fechaNcimientoLabel);
            this.grbRegistrarP.Controls.Add(this.fechaNcimientoDateTimePicker);
            this.grbRegistrarP.Controls.Add(grupoSanguineoLabel);
            this.grbRegistrarP.Controls.Add(this.grupoSanguineoTextBox);
            this.grbRegistrarP.Controls.Add(nombreLabel);
            this.grbRegistrarP.Controls.Add(this.nombreTextBox);
            this.grbRegistrarP.Controls.Add(nombreMadreLabel);
            this.grbRegistrarP.Controls.Add(this.nombreMadreTextBox);
            this.grbRegistrarP.Controls.Add(nombrePadreLabel);
            this.grbRegistrarP.Controls.Add(this.nombrePadreTextBox);
            this.grbRegistrarP.Controls.Add(numRegistroLabel);
            this.grbRegistrarP.Controls.Add(this.numRegistroTextBox);
            this.grbRegistrarP.Controls.Add(sexoLabel);
            this.grbRegistrarP.Controls.Add(this.sexoTextBox);
            this.grbRegistrarP.Controls.Add(telefonoLabel);
            this.grbRegistrarP.Controls.Add(this.telefonoTextBox);
            this.grbRegistrarP.Location = new System.Drawing.Point(12, 12);
            this.grbRegistrarP.Name = "grbRegistrarP";
            this.grbRegistrarP.Size = new System.Drawing.Size(331, 314);
            this.grbRegistrarP.TabIndex = 0;
            this.grbRegistrarP.TabStop = false;
            // 
            // btnGuardarP
            // 
            this.btnGuardarP.Location = new System.Drawing.Point(205, 332);
            this.btnGuardarP.Name = "btnGuardarP";
            this.btnGuardarP.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarP.TabIndex = 4;
            this.btnGuardarP.Text = "Guardar";
            this.btnGuardarP.UseVisualStyleBackColor = true;
            this.btnGuardarP.Click += new System.EventHandler(this.btnGuardarP_Click);
            // 
            // btnNuevoP
            // 
            this.btnNuevoP.Location = new System.Drawing.Point(90, 332);
            this.btnNuevoP.Name = "btnNuevoP";
            this.btnNuevoP.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoP.TabIndex = 3;
            this.btnNuevoP.Text = "Nuevo";
            this.btnNuevoP.UseVisualStyleBackColor = true;
            this.btnNuevoP.Click += new System.EventHandler(this.btnNuevoP_Click);
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataSource = typeof(ProyectoGetHospi.Entidades.Pacientes);
            // 
            // cédulaPacienteLabel
            // 
            cédulaPacienteLabel.AutoSize = true;
            cédulaPacienteLabel.Location = new System.Drawing.Point(17, 41);
            cédulaPacienteLabel.Name = "cédulaPacienteLabel";
            cédulaPacienteLabel.Size = new System.Drawing.Size(88, 13);
            cédulaPacienteLabel.TabIndex = 0;
            cédulaPacienteLabel.Text = "Cédula Paciente:";
            // 
            // cédulaPacienteTextBox
            // 
            this.cédulaPacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "CédulaPaciente", true));
            this.cédulaPacienteTextBox.Location = new System.Drawing.Point(116, 38);
            this.cédulaPacienteTextBox.Name = "cédulaPacienteTextBox";
            this.cédulaPacienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.cédulaPacienteTextBox.TabIndex = 1;
            // 
            // direcciónLabel
            // 
            direcciónLabel.AutoSize = true;
            direcciónLabel.Location = new System.Drawing.Point(17, 67);
            direcciónLabel.Name = "direcciónLabel";
            direcciónLabel.Size = new System.Drawing.Size(55, 13);
            direcciónLabel.TabIndex = 2;
            direcciónLabel.Text = "Dirección:";
            // 
            // direcciónTextBox
            // 
            this.direcciónTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Dirección", true));
            this.direcciónTextBox.Location = new System.Drawing.Point(116, 64);
            this.direcciónTextBox.Name = "direcciónTextBox";
            this.direcciónTextBox.Size = new System.Drawing.Size(200, 20);
            this.direcciónTextBox.TabIndex = 3;
            // 
            // fechaNcimientoLabel
            // 
            fechaNcimientoLabel.AutoSize = true;
            fechaNcimientoLabel.Location = new System.Drawing.Point(17, 94);
            fechaNcimientoLabel.Name = "fechaNcimientoLabel";
            fechaNcimientoLabel.Size = new System.Drawing.Size(90, 13);
            fechaNcimientoLabel.TabIndex = 4;
            fechaNcimientoLabel.Text = "Fecha Ncimiento:";
            // 
            // fechaNcimientoDateTimePicker
            // 
            this.fechaNcimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pacientesBindingSource, "FechaNcimiento", true));
            this.fechaNcimientoDateTimePicker.Location = new System.Drawing.Point(116, 90);
            this.fechaNcimientoDateTimePicker.Name = "fechaNcimientoDateTimePicker";
            this.fechaNcimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaNcimientoDateTimePicker.TabIndex = 5;
            // 
            // grupoSanguineoLabel
            // 
            grupoSanguineoLabel.AutoSize = true;
            grupoSanguineoLabel.Location = new System.Drawing.Point(17, 119);
            grupoSanguineoLabel.Name = "grupoSanguineoLabel";
            grupoSanguineoLabel.Size = new System.Drawing.Size(93, 13);
            grupoSanguineoLabel.TabIndex = 6;
            grupoSanguineoLabel.Text = "Grupo Sanguineo:";
            // 
            // grupoSanguineoTextBox
            // 
            this.grupoSanguineoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "GrupoSanguineo", true));
            this.grupoSanguineoTextBox.Location = new System.Drawing.Point(116, 116);
            this.grupoSanguineoTextBox.Name = "grupoSanguineoTextBox";
            this.grupoSanguineoTextBox.Size = new System.Drawing.Size(200, 20);
            this.grupoSanguineoTextBox.TabIndex = 7;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(17, 147);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 10;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(116, 144);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 11;
            // 
            // nombreMadreLabel
            // 
            nombreMadreLabel.AutoSize = true;
            nombreMadreLabel.Location = new System.Drawing.Point(17, 173);
            nombreMadreLabel.Name = "nombreMadreLabel";
            nombreMadreLabel.Size = new System.Drawing.Size(80, 13);
            nombreMadreLabel.TabIndex = 12;
            nombreMadreLabel.Text = "Nombre Madre:";
            // 
            // nombreMadreTextBox
            // 
            this.nombreMadreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "NombreMadre", true));
            this.nombreMadreTextBox.Location = new System.Drawing.Point(116, 170);
            this.nombreMadreTextBox.Name = "nombreMadreTextBox";
            this.nombreMadreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreMadreTextBox.TabIndex = 13;
            // 
            // nombrePadreLabel
            // 
            nombrePadreLabel.AutoSize = true;
            nombrePadreLabel.Location = new System.Drawing.Point(17, 199);
            nombrePadreLabel.Name = "nombrePadreLabel";
            nombrePadreLabel.Size = new System.Drawing.Size(78, 13);
            nombrePadreLabel.TabIndex = 14;
            nombrePadreLabel.Text = "Nombre Padre:";
            // 
            // nombrePadreTextBox
            // 
            this.nombrePadreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "NombrePadre", true));
            this.nombrePadreTextBox.Location = new System.Drawing.Point(116, 196);
            this.nombrePadreTextBox.Name = "nombrePadreTextBox";
            this.nombrePadreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombrePadreTextBox.TabIndex = 15;
            // 
            // numRegistroLabel
            // 
            numRegistroLabel.AutoSize = true;
            numRegistroLabel.Location = new System.Drawing.Point(17, 225);
            numRegistroLabel.Name = "numRegistroLabel";
            numRegistroLabel.Size = new System.Drawing.Size(74, 13);
            numRegistroLabel.TabIndex = 16;
            numRegistroLabel.Text = "Num Registro:";
            // 
            // numRegistroTextBox
            // 
            this.numRegistroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "NumRegistro", true));
            this.numRegistroTextBox.Location = new System.Drawing.Point(116, 222);
            this.numRegistroTextBox.Name = "numRegistroTextBox";
            this.numRegistroTextBox.Size = new System.Drawing.Size(200, 20);
            this.numRegistroTextBox.TabIndex = 17;
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(17, 251);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(34, 13);
            sexoLabel.TabIndex = 18;
            sexoLabel.Text = "Sexo:";
            // 
            // sexoTextBox
            // 
            this.sexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Sexo", true));
            this.sexoTextBox.Location = new System.Drawing.Point(116, 248);
            this.sexoTextBox.Name = "sexoTextBox";
            this.sexoTextBox.Size = new System.Drawing.Size(200, 20);
            this.sexoTextBox.TabIndex = 19;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(17, 277);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 20;
            telefonoLabel.Text = "Telefono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacientesBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(116, 274);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefonoTextBox.TabIndex = 21;
            // 
            // RegistrarP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 367);
            this.Controls.Add(this.btnGuardarP);
            this.Controls.Add(this.btnNuevoP);
            this.Controls.Add(this.grbRegistrarP);
            this.Name = "RegistrarP";
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.RegistrarP_Load);
            this.grbRegistrarP.ResumeLayout(false);
            this.grbRegistrarP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRegistrarP;
        private System.Windows.Forms.Button btnGuardarP;
        private System.Windows.Forms.Button btnNuevoP;
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
    }
}