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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarMed));
            System.Windows.Forms.Label cedulaMedicoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label dUILabel;
            System.Windows.Forms.Label idMedicoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label telefonoLabel;
            this.dgvMedA = new System.Windows.Forms.DataGridView();
            this.grbMedA = new System.Windows.Forms.GroupBox();
            this.btnSeleccionMed = new System.Windows.Forms.Button();
            this.btnGuardarMed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.medicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idMedicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaMedicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaMedicoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.dUITextBox = new System.Windows.Forms.TextBox();
            this.idMedicoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            cedulaMedicoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            dUILabel = new System.Windows.Forms.Label();
            idMedicoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedA)).BeginInit();
            this.grbMedA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMedA
            // 
            this.dgvMedA.AllowUserToAddRows = false;
            this.dgvMedA.AllowUserToDeleteRows = false;
            this.dgvMedA.AutoGenerateColumns = false;
            this.dgvMedA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            this.dgvMedA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMedA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMedicoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.dUIDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.cedulaMedicoDataGridViewTextBoxColumn});
            this.dgvMedA.DataSource = this.medicosBindingSource;
            this.dgvMedA.Location = new System.Drawing.Point(35, 45);
            this.dgvMedA.Name = "dgvMedA";
            this.dgvMedA.ReadOnly = true;
            this.dgvMedA.Size = new System.Drawing.Size(450, 243);
            this.dgvMedA.TabIndex = 1;
            // 
            // grbMedA
            // 
            this.grbMedA.Controls.Add(cedulaMedicoLabel);
            this.grbMedA.Controls.Add(this.cedulaMedicoTextBox);
            this.grbMedA.Controls.Add(direccionLabel);
            this.grbMedA.Controls.Add(this.direccionTextBox);
            this.grbMedA.Controls.Add(dUILabel);
            this.grbMedA.Controls.Add(this.dUITextBox);
            this.grbMedA.Controls.Add(idMedicoLabel);
            this.grbMedA.Controls.Add(this.idMedicoTextBox);
            this.grbMedA.Controls.Add(nombreLabel);
            this.grbMedA.Controls.Add(this.nombreTextBox);
            this.grbMedA.Controls.Add(telefonoLabel);
            this.grbMedA.Controls.Add(this.telefonoTextBox);
            this.grbMedA.Location = new System.Drawing.Point(504, 61);
            this.grbMedA.Name = "grbMedA";
            this.grbMedA.Size = new System.Drawing.Size(281, 214);
            this.grbMedA.TabIndex = 2;
            this.grbMedA.TabStop = false;
            // 
            // btnSeleccionMed
            // 
            this.btnSeleccionMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnSeleccionMed.FlatAppearance.BorderSize = 0;
            this.btnSeleccionMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionMed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionMed.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionMed.Image")));
            this.btnSeleccionMed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionMed.Location = new System.Drawing.Point(180, 294);
            this.btnSeleccionMed.Name = "btnSeleccionMed";
            this.btnSeleccionMed.Size = new System.Drawing.Size(117, 30);
            this.btnSeleccionMed.TabIndex = 3;
            this.btnSeleccionMed.Text = "Seleccionar";
            this.btnSeleccionMed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionMed.UseVisualStyleBackColor = false;
            this.btnSeleccionMed.Click += new System.EventHandler(this.btnSeleccionMed_Click);
            // 
            // btnGuardarMed
            // 
            this.btnGuardarMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnGuardarMed.FlatAppearance.BorderSize = 0;
            this.btnGuardarMed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarMed.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMed.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarMed.Image")));
            this.btnGuardarMed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarMed.Location = new System.Drawing.Point(595, 281);
            this.btnGuardarMed.Name = "btnGuardarMed";
            this.btnGuardarMed.Size = new System.Drawing.Size(97, 30);
            this.btnGuardarMed.TabIndex = 4;
            this.btnGuardarMed.Text = "Guardar";
            this.btnGuardarMed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarMed.UseVisualStyleBackColor = false;
            this.btnGuardarMed.Click += new System.EventHandler(this.btnGuardarMed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(561, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Actualizar Médico";
            // 
            // medicosBindingSource
            // 
            this.medicosBindingSource.DataSource = typeof(ProyectoGetHospi.Entidades.Médico);
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
            // cedulaMedicoLabel
            // 
            cedulaMedicoLabel.AutoSize = true;
            cedulaMedicoLabel.Location = new System.Drawing.Point(58, 32);
            cedulaMedicoLabel.Name = "cedulaMedicoLabel";
            cedulaMedicoLabel.Size = new System.Drawing.Size(81, 13);
            cedulaMedicoLabel.TabIndex = 0;
            cedulaMedicoLabel.Text = "Cedula Medico:";
            // 
            // cedulaMedicoTextBox
            // 
            this.cedulaMedicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "CedulaMedico", true));
            this.cedulaMedicoTextBox.Location = new System.Drawing.Point(145, 29);
            this.cedulaMedicoTextBox.Name = "cedulaMedicoTextBox";
            this.cedulaMedicoTextBox.Size = new System.Drawing.Size(100, 20);
            this.cedulaMedicoTextBox.TabIndex = 1;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(58, 58);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 2;
            direccionLabel.Text = "Direccion:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(145, 55);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox.TabIndex = 3;
            // 
            // dUILabel
            // 
            dUILabel.AutoSize = true;
            dUILabel.Location = new System.Drawing.Point(58, 84);
            dUILabel.Name = "dUILabel";
            dUILabel.Size = new System.Drawing.Size(29, 13);
            dUILabel.TabIndex = 4;
            dUILabel.Text = "DUI:";
            // 
            // dUITextBox
            // 
            this.dUITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "DUI", true));
            this.dUITextBox.Location = new System.Drawing.Point(145, 81);
            this.dUITextBox.Name = "dUITextBox";
            this.dUITextBox.Size = new System.Drawing.Size(100, 20);
            this.dUITextBox.TabIndex = 5;
            // 
            // idMedicoLabel
            // 
            idMedicoLabel.AutoSize = true;
            idMedicoLabel.Location = new System.Drawing.Point(58, 110);
            idMedicoLabel.Name = "idMedicoLabel";
            idMedicoLabel.Size = new System.Drawing.Size(57, 13);
            idMedicoLabel.TabIndex = 6;
            idMedicoLabel.Text = "Id Medico:";
            // 
            // idMedicoTextBox
            // 
            this.idMedicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "IdMedico", true));
            this.idMedicoTextBox.Location = new System.Drawing.Point(145, 107);
            this.idMedicoTextBox.Name = "idMedicoTextBox";
            this.idMedicoTextBox.Size = new System.Drawing.Size(100, 20);
            this.idMedicoTextBox.TabIndex = 7;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(58, 136);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 8;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(145, 133);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 9;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(58, 162);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 10;
            telefonoLabel.Text = "Telefono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicosBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(145, 159);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 11;
            // 
            // ActualizarMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(797, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarMed);
            this.Controls.Add(this.btnSeleccionMed);
            this.Controls.Add(this.grbMedA);
            this.Controls.Add(this.dgvMedA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ActualizarMed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar";
            this.Load += new System.EventHandler(this.ActualizarMed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedA)).EndInit();
            this.grbMedA.ResumeLayout(false);
            this.grbMedA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMedA;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.GroupBox grbMedA;
        private System.Windows.Forms.Button btnSeleccionMed;
        private System.Windows.Forms.Button btnGuardarMed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaMedicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource medicosBindingSource;
        private System.Windows.Forms.TextBox cedulaMedicoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox dUITextBox;
        private System.Windows.Forms.TextBox idMedicoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
    }
}