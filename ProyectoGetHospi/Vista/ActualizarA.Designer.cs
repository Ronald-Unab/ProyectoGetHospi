namespace ProyectoGetHospi.Vista
{
    partial class ActualizarA
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
            System.Windows.Forms.Label idArchivoLabel;
            System.Windows.Forms.Label idPacienteLabel;
            System.Windows.Forms.Label pesoLabel;
            System.Windows.Forms.Label presionArterialLabel;
            System.Windows.Forms.Label temperaturaLabel;
            this.archivoDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.idArchivoTextBox = new System.Windows.Forms.TextBox();
            this.idPacienteTextBox = new System.Windows.Forms.TextBox();
            this.pesoTextBox = new System.Windows.Forms.TextBox();
            this.presionArterialTextBox = new System.Windows.Forms.TextBox();
            this.temperaturaTextBox = new System.Windows.Forms.TextBox();
            this.archivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idArchivoLabel = new System.Windows.Forms.Label();
            idPacienteLabel = new System.Windows.Forms.Label();
            pesoLabel = new System.Windows.Forms.Label();
            presionArterialLabel = new System.Windows.Forms.Label();
            temperaturaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.archivoDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archivoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // archivoDataGridView
            // 
            this.archivoDataGridView.AllowUserToAddRows = false;
            this.archivoDataGridView.AllowUserToDeleteRows = false;
            this.archivoDataGridView.AutoGenerateColumns = false;
            this.archivoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.archivoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archivoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.archivoDataGridView.DataSource = this.archivoBindingSource;
            this.archivoDataGridView.Location = new System.Drawing.Point(19, 32);
            this.archivoDataGridView.Name = "archivoDataGridView";
            this.archivoDataGridView.ReadOnly = true;
            this.archivoDataGridView.Size = new System.Drawing.Size(458, 254);
            this.archivoDataGridView.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idArchivoLabel);
            this.groupBox1.Controls.Add(this.idArchivoTextBox);
            this.groupBox1.Controls.Add(idPacienteLabel);
            this.groupBox1.Controls.Add(this.idPacienteTextBox);
            this.groupBox1.Controls.Add(pesoLabel);
            this.groupBox1.Controls.Add(this.pesoTextBox);
            this.groupBox1.Controls.Add(presionArterialLabel);
            this.groupBox1.Controls.Add(this.presionArterialTextBox);
            this.groupBox1.Controls.Add(temperaturaLabel);
            this.groupBox1.Controls.Add(this.temperaturaTextBox);
            this.groupBox1.Location = new System.Drawing.Point(504, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 193);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(504, 262);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(628, 261);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // idArchivoLabel
            // 
            idArchivoLabel.AutoSize = true;
            idArchivoLabel.Location = new System.Drawing.Point(17, 42);
            idArchivoLabel.Name = "idArchivoLabel";
            idArchivoLabel.Size = new System.Drawing.Size(58, 13);
            idArchivoLabel.TabIndex = 0;
            idArchivoLabel.Text = "Id Archivo:";
            // 
            // idArchivoTextBox
            // 
            this.idArchivoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.archivoBindingSource, "IdArchivo", true));
            this.idArchivoTextBox.Location = new System.Drawing.Point(103, 39);
            this.idArchivoTextBox.Name = "idArchivoTextBox";
            this.idArchivoTextBox.Size = new System.Drawing.Size(100, 20);
            this.idArchivoTextBox.TabIndex = 1;
            // 
            // idPacienteLabel
            // 
            idPacienteLabel.AutoSize = true;
            idPacienteLabel.Location = new System.Drawing.Point(17, 68);
            idPacienteLabel.Name = "idPacienteLabel";
            idPacienteLabel.Size = new System.Drawing.Size(64, 13);
            idPacienteLabel.TabIndex = 2;
            idPacienteLabel.Text = "Id Paciente:";
            // 
            // idPacienteTextBox
            // 
            this.idPacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.archivoBindingSource, "IdPaciente", true));
            this.idPacienteTextBox.Location = new System.Drawing.Point(103, 65);
            this.idPacienteTextBox.Name = "idPacienteTextBox";
            this.idPacienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.idPacienteTextBox.TabIndex = 3;
            // 
            // pesoLabel
            // 
            pesoLabel.AutoSize = true;
            pesoLabel.Location = new System.Drawing.Point(17, 94);
            pesoLabel.Name = "pesoLabel";
            pesoLabel.Size = new System.Drawing.Size(34, 13);
            pesoLabel.TabIndex = 4;
            pesoLabel.Text = "Peso:";
            // 
            // pesoTextBox
            // 
            this.pesoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.archivoBindingSource, "Peso", true));
            this.pesoTextBox.Location = new System.Drawing.Point(103, 91);
            this.pesoTextBox.Name = "pesoTextBox";
            this.pesoTextBox.Size = new System.Drawing.Size(100, 20);
            this.pesoTextBox.TabIndex = 5;
            // 
            // presionArterialLabel
            // 
            presionArterialLabel.AutoSize = true;
            presionArterialLabel.Location = new System.Drawing.Point(17, 120);
            presionArterialLabel.Name = "presionArterialLabel";
            presionArterialLabel.Size = new System.Drawing.Size(80, 13);
            presionArterialLabel.TabIndex = 6;
            presionArterialLabel.Text = "Presion Arterial:";
            // 
            // presionArterialTextBox
            // 
            this.presionArterialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.archivoBindingSource, "PresionArterial", true));
            this.presionArterialTextBox.Location = new System.Drawing.Point(103, 117);
            this.presionArterialTextBox.Name = "presionArterialTextBox";
            this.presionArterialTextBox.Size = new System.Drawing.Size(100, 20);
            this.presionArterialTextBox.TabIndex = 7;
            // 
            // temperaturaLabel
            // 
            temperaturaLabel.AutoSize = true;
            temperaturaLabel.Location = new System.Drawing.Point(17, 146);
            temperaturaLabel.Name = "temperaturaLabel";
            temperaturaLabel.Size = new System.Drawing.Size(70, 13);
            temperaturaLabel.TabIndex = 8;
            temperaturaLabel.Text = "Temperatura:";
            // 
            // temperaturaTextBox
            // 
            this.temperaturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.archivoBindingSource, "Temperatura", true));
            this.temperaturaTextBox.Location = new System.Drawing.Point(103, 143);
            this.temperaturaTextBox.Name = "temperaturaTextBox";
            this.temperaturaTextBox.Size = new System.Drawing.Size(100, 20);
            this.temperaturaTextBox.TabIndex = 9;
            // 
            // archivoBindingSource
            // 
//            this.archivoBindingSource.DataSource = typeof(ProyectoGetHospi.Entidades.Archivo);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdArchivo";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdArchivo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Peso";
            this.dataGridViewTextBoxColumn2.HeaderText = "Peso";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PresionArterial";
            this.dataGridViewTextBoxColumn3.HeaderText = "PresionArterial";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Temperatura";
            this.dataGridViewTextBoxColumn4.HeaderText = "Temperatura";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "IdPaciente";
            this.dataGridViewTextBoxColumn5.HeaderText = "IdPaciente";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // ActualizarA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 347);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.archivoDataGridView);
            this.Name = "ActualizarA";
            this.Text = "Actualizar";
            ((System.ComponentModel.ISupportInitialize)(this.archivoDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archivoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource archivoBindingSource;
        private System.Windows.Forms.DataGridView archivoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idArchivoTextBox;
        private System.Windows.Forms.TextBox idPacienteTextBox;
        private System.Windows.Forms.TextBox pesoTextBox;
        private System.Windows.Forms.TextBox presionArterialTextBox;
        private System.Windows.Forms.TextBox temperaturaTextBox;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnGuardar;
    }
}