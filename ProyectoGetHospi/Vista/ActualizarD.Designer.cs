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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarD));
            this.diagnosticosDataGridView = new System.Windows.Forms.DataGridView();
            this.diagnosticosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.diagnosticoTextBox = new System.Windows.Forms.TextBox();
            this.idConsultaTextBox = new System.Windows.Forms.TextBox();
            this.idDiagnosticoTextBox = new System.Windows.Forms.TextBox();
            this.recetasTextBox = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            diagnosticoLabel = new System.Windows.Forms.Label();
            idConsultaLabel = new System.Windows.Forms.Label();
            idDiagnosticoLabel = new System.Windows.Forms.Label();
            recetasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // diagnosticoLabel
            // 
            diagnosticoLabel.AutoSize = true;
            diagnosticoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diagnosticoLabel.Location = new System.Drawing.Point(15, 106);
            diagnosticoLabel.Name = "diagnosticoLabel";
            diagnosticoLabel.Size = new System.Drawing.Size(100, 20);
            diagnosticoLabel.TabIndex = 0;
            diagnosticoLabel.Text = "Diagnostico:";
            // 
            // idConsultaLabel
            // 
            idConsultaLabel.AutoSize = true;
            idConsultaLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idConsultaLabel.Location = new System.Drawing.Point(15, 66);
            idConsultaLabel.Name = "idConsultaLabel";
            idConsultaLabel.Size = new System.Drawing.Size(96, 20);
            idConsultaLabel.TabIndex = 2;
            idConsultaLabel.Text = "Id Consulta:";
            // 
            // idDiagnosticoLabel
            // 
            idDiagnosticoLabel.AutoSize = true;
            idDiagnosticoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idDiagnosticoLabel.Location = new System.Drawing.Point(15, 28);
            idDiagnosticoLabel.Name = "idDiagnosticoLabel";
            idDiagnosticoLabel.Size = new System.Drawing.Size(119, 20);
            idDiagnosticoLabel.TabIndex = 4;
            idDiagnosticoLabel.Text = "Id Diagnostico:";
            // 
            // recetasLabel
            // 
            recetasLabel.AutoSize = true;
            recetasLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            recetasLabel.Location = new System.Drawing.Point(15, 143);
            recetasLabel.Name = "recetasLabel";
            recetasLabel.Size = new System.Drawing.Size(73, 20);
            recetasLabel.TabIndex = 6;
            recetasLabel.Text = "Recetas:";
            // 
            // diagnosticosDataGridView
            // 
            this.diagnosticosDataGridView.AllowUserToAddRows = false;
            this.diagnosticosDataGridView.AllowUserToDeleteRows = false;
            this.diagnosticosDataGridView.AutoGenerateColumns = false;
            this.diagnosticosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.diagnosticosDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            this.diagnosticosDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diagnosticosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diagnosticosDataGridView.DataSource = this.diagnosticosBindingSource;
            this.diagnosticosDataGridView.Location = new System.Drawing.Point(35, 45);
            this.diagnosticosDataGridView.Name = "diagnosticosDataGridView";
            this.diagnosticosDataGridView.ReadOnly = true;
            this.diagnosticosDataGridView.Size = new System.Drawing.Size(450, 243);
            this.diagnosticosDataGridView.TabIndex = 1;
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
            this.groupBox1.Location = new System.Drawing.Point(504, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 182);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // diagnosticoTextBox
            // 
            this.diagnosticoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diagnosticoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosticosBindingSource, "Diagnostico", true));
            this.diagnosticoTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosticoTextBox.Location = new System.Drawing.Point(136, 106);
            this.diagnosticoTextBox.Name = "diagnosticoTextBox";
            this.diagnosticoTextBox.Size = new System.Drawing.Size(115, 19);
            this.diagnosticoTextBox.TabIndex = 1;
            // 
            // idConsultaTextBox
            // 
            this.idConsultaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idConsultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosticosBindingSource, "IdConsulta", true));
            this.idConsultaTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idConsultaTextBox.Location = new System.Drawing.Point(136, 66);
            this.idConsultaTextBox.Name = "idConsultaTextBox";
            this.idConsultaTextBox.Size = new System.Drawing.Size(115, 19);
            this.idConsultaTextBox.TabIndex = 3;
            // 
            // idDiagnosticoTextBox
            // 
            this.idDiagnosticoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idDiagnosticoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosticosBindingSource, "IdDiagnostico", true));
            this.idDiagnosticoTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idDiagnosticoTextBox.Location = new System.Drawing.Point(136, 28);
            this.idDiagnosticoTextBox.Name = "idDiagnosticoTextBox";
            this.idDiagnosticoTextBox.Size = new System.Drawing.Size(115, 19);
            this.idDiagnosticoTextBox.TabIndex = 5;
            // 
            // recetasTextBox
            // 
            this.recetasTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recetasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosticosBindingSource, "Recetas", true));
            this.recetasTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recetasTextBox.Location = new System.Drawing.Point(136, 143);
            this.recetasTextBox.Name = "recetasTextBox";
            this.recetasTextBox.Size = new System.Drawing.Size(115, 19);
            this.recetasTextBox.TabIndex = 7;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(179, 294);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(115, 31);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(582, 270);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 31);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Actualizar Diagnostico";
            // 
            // ActualizarD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(797, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.diagnosticosDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ActualizarD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar";
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
    }
}