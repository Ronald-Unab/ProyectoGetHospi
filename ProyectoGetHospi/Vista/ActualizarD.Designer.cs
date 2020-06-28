namespace ProyectoGetHospi.Vista
{
    partial class ActualizarD
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
            System.Windows.Forms.Label diagnosticoLabel;
            System.Windows.Forms.Label idConsultaLabel;
            System.Windows.Forms.Label idDiagnosticoLabel;
            System.Windows.Forms.Label recetasLabel;
            this.diagnosticosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.diagnosticoTextBox = new System.Windows.Forms.TextBox();
            this.idConsultaTextBox = new System.Windows.Forms.TextBox();
            this.idDiagnosticoTextBox = new System.Windows.Forms.TextBox();
            this.recetasTextBox = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            diagnosticoLabel = new System.Windows.Forms.Label();
            idConsultaLabel = new System.Windows.Forms.Label();
            idDiagnosticoLabel = new System.Windows.Forms.Label();
            recetasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // diagnosticosDataGridView
            // 
            this.diagnosticosDataGridView.AllowUserToAddRows = false;
            this.diagnosticosDataGridView.AllowUserToDeleteRows = false;
            this.diagnosticosDataGridView.AutoGenerateColumns = false;
            this.diagnosticosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.diagnosticosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diagnosticosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.diagnosticosDataGridView.DataSource = this.diagnosticosBindingSource;
            this.diagnosticosDataGridView.Location = new System.Drawing.Point(12, 12);
            this.diagnosticosDataGridView.Name = "diagnosticosDataGridView";
            this.diagnosticosDataGridView.ReadOnly = true;
            this.diagnosticosDataGridView.Size = new System.Drawing.Size(430, 272);
            this.diagnosticosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdDiagnostico";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdDiagnostico";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Diagnostico";
            this.dataGridViewTextBoxColumn2.HeaderText = "Diagnostico";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Recetas";
            this.dataGridViewTextBoxColumn3.HeaderText = "Recetas";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdConsulta";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdConsulta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // diagnosticosBindingSource
            // 
            this.diagnosticosBindingSource.DataSource = typeof(ProyectoGetHospi.Entidades.Diagnosticos);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(diagnosticoLabel);
            this.groupBox1.Controls.Add(this.diagnosticoTextBox);
            this.groupBox1.Controls.Add(idConsultaLabel);
            this.groupBox1.Controls.Add(this.idConsultaTextBox);
            this.groupBox1.Controls.Add(idDiagnosticoLabel);
            this.groupBox1.Controls.Add(this.idDiagnosticoTextBox);
            this.groupBox1.Controls.Add(recetasLabel);
            this.groupBox1.Controls.Add(this.recetasTextBox);
            this.groupBox1.Location = new System.Drawing.Point(449, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 163);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // diagnosticoLabel
            // 
            diagnosticoLabel.AutoSize = true;
            diagnosticoLabel.Location = new System.Drawing.Point(15, 46);
            diagnosticoLabel.Name = "diagnosticoLabel";
            diagnosticoLabel.Size = new System.Drawing.Size(66, 13);
            diagnosticoLabel.TabIndex = 0;
            diagnosticoLabel.Text = "Diagnostico:";
            // 
            // diagnosticoTextBox
            // 
            this.diagnosticoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosticosBindingSource, "Diagnostico", true));
            this.diagnosticoTextBox.Location = new System.Drawing.Point(99, 46);
            this.diagnosticoTextBox.Name = "diagnosticoTextBox";
            this.diagnosticoTextBox.Size = new System.Drawing.Size(100, 20);
            this.diagnosticoTextBox.TabIndex = 1;
            // 
            // idConsultaLabel
            // 
            idConsultaLabel.AutoSize = true;
            idConsultaLabel.Location = new System.Drawing.Point(15, 72);
            idConsultaLabel.Name = "idConsultaLabel";
            idConsultaLabel.Size = new System.Drawing.Size(63, 13);
            idConsultaLabel.TabIndex = 2;
            idConsultaLabel.Text = "Id Consulta:";
            // 
            // idConsultaTextBox
            // 
            this.idConsultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosticosBindingSource, "IdConsulta", true));
            this.idConsultaTextBox.Location = new System.Drawing.Point(99, 69);
            this.idConsultaTextBox.Name = "idConsultaTextBox";
            this.idConsultaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idConsultaTextBox.TabIndex = 3;
            // 
            // idDiagnosticoLabel
            // 
            idDiagnosticoLabel.AutoSize = true;
            idDiagnosticoLabel.Location = new System.Drawing.Point(15, 98);
            idDiagnosticoLabel.Name = "idDiagnosticoLabel";
            idDiagnosticoLabel.Size = new System.Drawing.Size(78, 13);
            idDiagnosticoLabel.TabIndex = 4;
            idDiagnosticoLabel.Text = "Id Diagnostico:";
            // 
            // idDiagnosticoTextBox
            // 
            this.idDiagnosticoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosticosBindingSource, "IdDiagnostico", true));
            this.idDiagnosticoTextBox.Location = new System.Drawing.Point(99, 95);
            this.idDiagnosticoTextBox.Name = "idDiagnosticoTextBox";
            this.idDiagnosticoTextBox.Size = new System.Drawing.Size(100, 20);
            this.idDiagnosticoTextBox.TabIndex = 5;
            // 
            // recetasLabel
            // 
            recetasLabel.AutoSize = true;
            recetasLabel.Location = new System.Drawing.Point(15, 124);
            recetasLabel.Name = "recetasLabel";
            recetasLabel.Size = new System.Drawing.Size(50, 13);
            recetasLabel.TabIndex = 6;
            recetasLabel.Text = "Recetas:";
            // 
            // recetasTextBox
            // 
            this.recetasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosticosBindingSource, "Recetas", true));
            this.recetasTextBox.Location = new System.Drawing.Point(99, 121);
            this.recetasTextBox.Name = "recetasTextBox";
            this.recetasTextBox.Size = new System.Drawing.Size(100, 20);
            this.recetasTextBox.TabIndex = 7;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(467, 261);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(572, 261);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // ActualizarD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 318);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.diagnosticosDataGridView);
            this.Name = "ActualizarD";
            this.Text = "Actualizar";
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource diagnosticosBindingSource;
        private System.Windows.Forms.DataGridView diagnosticosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox diagnosticoTextBox;
        private System.Windows.Forms.TextBox idConsultaTextBox;
        private System.Windows.Forms.TextBox idDiagnosticoTextBox;
        private System.Windows.Forms.TextBox recetasTextBox;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnGuardar;
    }
}