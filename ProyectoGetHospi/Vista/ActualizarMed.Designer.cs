namespace ProyectoGetHospi.Vista
{
    partial class ActualizarMed
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
            System.Windows.Forms.Label cedulaMedicoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label dUILabel;
            System.Windows.Forms.Label idMedicoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label telefonoLabel;
            this.dgvMedA = new System.Windows.Forms.DataGridView();
            this.grbMedA = new System.Windows.Forms.GroupBox();
            this.cedulaMedicoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.dUITextBox = new System.Windows.Forms.TextBox();
            this.idMedicoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.btnSeleccionMed = new System.Windows.Forms.Button();
            this.btnGuardarMed = new System.Windows.Forms.Button();
            this.IdMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.médicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cedulaMedicoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            dUILabel = new System.Windows.Forms.Label();
            idMedicoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedA)).BeginInit();
            this.grbMedA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.médicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedA
            // 
            this.dgvMedA.AllowUserToAddRows = false;
            this.dgvMedA.AllowUserToDeleteRows = false;
            this.dgvMedA.AutoGenerateColumns = false;
            this.dgvMedA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMedico,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvMedA.DataSource = this.médicoBindingSource;
            this.dgvMedA.Location = new System.Drawing.Point(17, 64);
            this.dgvMedA.Name = "dgvMedA";
            this.dgvMedA.ReadOnly = true;
            this.dgvMedA.Size = new System.Drawing.Size(300, 220);
            this.dgvMedA.TabIndex = 1;
            // 
            // grbMedA
            // 
            this.grbMedA.Controls.Add(cedulaMedicoLabel);
            this.grbMedA.Controls.Add(this.cedulaMedicoTextBox);
            this.grbMedA.Controls.Add(direccionLabel);
            this.grbMedA.Controls.Add(this.direccionTextBox);
            this.grbMedA.Controls.Add(dUILabel);
            this.grbMedA.Controls.Add(idMedicoLabel);
            this.grbMedA.Controls.Add(this.dUITextBox);
            this.grbMedA.Controls.Add(this.idMedicoTextBox);
            this.grbMedA.Controls.Add(nombreLabel);
            this.grbMedA.Controls.Add(this.nombreTextBox);
            this.grbMedA.Controls.Add(telefonoLabel);
            this.grbMedA.Controls.Add(this.telefonoTextBox);
            this.grbMedA.Location = new System.Drawing.Point(324, 64);
            this.grbMedA.Name = "grbMedA";
            this.grbMedA.Size = new System.Drawing.Size(265, 199);
            this.grbMedA.TabIndex = 2;
            this.grbMedA.TabStop = false;
            // 
            // cedulaMedicoLabel
            // 
            cedulaMedicoLabel.AutoSize = true;
            cedulaMedicoLabel.Location = new System.Drawing.Point(40, 36);
            cedulaMedicoLabel.Name = "cedulaMedicoLabel";
            cedulaMedicoLabel.Size = new System.Drawing.Size(81, 13);
            cedulaMedicoLabel.TabIndex = 0;
            cedulaMedicoLabel.Text = "Cedula Medico:";
            // 
            // cedulaMedicoTextBox
            // 
            this.cedulaMedicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "CedulaMedico", true));
            this.cedulaMedicoTextBox.Location = new System.Drawing.Point(127, 33);
            this.cedulaMedicoTextBox.Name = "cedulaMedicoTextBox";
            this.cedulaMedicoTextBox.Size = new System.Drawing.Size(100, 20);
            this.cedulaMedicoTextBox.TabIndex = 1;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(40, 62);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 2;
            direccionLabel.Text = "Direccion:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(127, 59);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox.TabIndex = 3;
            // 
            // dUILabel
            // 
            dUILabel.AutoSize = true;
            dUILabel.Location = new System.Drawing.Point(40, 88);
            dUILabel.Name = "dUILabel";
            dUILabel.Size = new System.Drawing.Size(29, 13);
            dUILabel.TabIndex = 4;
            dUILabel.Text = "DUI:";
            // 
            // dUITextBox
            // 
            this.dUITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "DUI", true));
            this.dUITextBox.Location = new System.Drawing.Point(127, 85);
            this.dUITextBox.Name = "dUITextBox";
            this.dUITextBox.Size = new System.Drawing.Size(100, 20);
            this.dUITextBox.TabIndex = 5;
            // 
            // idMedicoLabel
            // 
            idMedicoLabel.AutoSize = true;
            idMedicoLabel.Location = new System.Drawing.Point(40, 114);
            idMedicoLabel.Name = "idMedicoLabel";
            idMedicoLabel.Size = new System.Drawing.Size(57, 13);
            idMedicoLabel.TabIndex = 6;
            idMedicoLabel.Text = "Id Medico:";
            // 
            // idMedicoTextBox
            // 
            this.idMedicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "IdMedico", true));
            this.idMedicoTextBox.Location = new System.Drawing.Point(127, 111);
            this.idMedicoTextBox.Name = "idMedicoTextBox";
            this.idMedicoTextBox.Size = new System.Drawing.Size(100, 20);
            this.idMedicoTextBox.TabIndex = 7;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(40, 140);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 8;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(127, 137);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 9;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(40, 166);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 10;
            telefonoLabel.Text = "Telefono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(127, 163);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 11;
            // 
            // btnSeleccionMed
            // 
            this.btnSeleccionMed.Location = new System.Drawing.Point(385, 270);
            this.btnSeleccionMed.Name = "btnSeleccionMed";
            this.btnSeleccionMed.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionMed.TabIndex = 3;
            this.btnSeleccionMed.Text = "Seleccionar";
            this.btnSeleccionMed.UseVisualStyleBackColor = true;
            this.btnSeleccionMed.Click += new System.EventHandler(this.btnSeleccionMed_Click);
            // 
            // btnGuardarMed
            // 
            this.btnGuardarMed.Location = new System.Drawing.Point(467, 270);
            this.btnGuardarMed.Name = "btnGuardarMed";
            this.btnGuardarMed.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarMed.TabIndex = 4;
            this.btnGuardarMed.Text = "Guardar";
            this.btnGuardarMed.UseVisualStyleBackColor = true;
            this.btnGuardarMed.Click += new System.EventHandler(this.btnGuardarMed_Click);
            // 
            // IdMedico
            // 
            this.IdMedico.DataPropertyName = "IdMedico";
            this.IdMedico.HeaderText = "IdMedico";
            this.IdMedico.Name = "IdMedico";
            this.IdMedico.ReadOnly = true;
            // 
            // médicoBindingSource
            // 
            this.médicoBindingSource.DataSource = typeof(ProyectoGetHospi.Entidades.Médico);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DUI";
            this.dataGridViewTextBoxColumn4.HeaderText = "DUI";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CedulaMedico";
            this.dataGridViewTextBoxColumn6.HeaderText = "CedulaMedico";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // ActualizarMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 364);
            this.Controls.Add(this.btnGuardarMed);
            this.Controls.Add(this.btnSeleccionMed);
            this.Controls.Add(this.grbMedA);
            this.Controls.Add(this.dgvMedA);
            this.Name = "ActualizarMed";
            this.Text = "Actualizar";
            this.Load += new System.EventHandler(this.ActualizarMed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedA)).EndInit();
            this.grbMedA.ResumeLayout(false);
            this.grbMedA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.médicoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource médicoBindingSource;
        private System.Windows.Forms.DataGridView dgvMedA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox grbMedA;
        private System.Windows.Forms.TextBox cedulaMedicoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox dUITextBox;
        private System.Windows.Forms.TextBox idMedicoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.Button btnSeleccionMed;
        private System.Windows.Forms.Button btnGuardarMed;
    }
}