namespace ProyectoGetHospi.Vista
{
    partial class RegistrarD
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.diagnosticosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diagnosticoTextBox = new System.Windows.Forms.TextBox();
            this.idConsultaTextBox = new System.Windows.Forms.TextBox();
            this.idDiagnosticoTextBox = new System.Windows.Forms.TextBox();
            this.recetasTextBox = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            diagnosticoLabel = new System.Windows.Forms.Label();
            idConsultaLabel = new System.Windows.Forms.Label();
            idDiagnosticoLabel = new System.Windows.Forms.Label();
            recetasLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 170);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // diagnosticosBindingSource
            // 
            //this.diagnosticosBindingSource.DataSource = typeof(ProyectoGetHospi.Entidades.Diagnosticos);
            // 
            // diagnosticoLabel
            // 
            diagnosticoLabel.AutoSize = true;
            diagnosticoLabel.Location = new System.Drawing.Point(30, 41);
            diagnosticoLabel.Name = "diagnosticoLabel";
            diagnosticoLabel.Size = new System.Drawing.Size(66, 13);
            diagnosticoLabel.TabIndex = 0;
            diagnosticoLabel.Text = "Diagnostico:";
            // 
            // diagnosticoTextBox
            // 
            this.diagnosticoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosticosBindingSource, "Diagnostico", true));
            this.diagnosticoTextBox.Location = new System.Drawing.Point(114, 38);
            this.diagnosticoTextBox.Name = "diagnosticoTextBox";
            this.diagnosticoTextBox.Size = new System.Drawing.Size(100, 20);
            this.diagnosticoTextBox.TabIndex = 1;
            // 
            // idConsultaLabel
            // 
            idConsultaLabel.AutoSize = true;
            idConsultaLabel.Location = new System.Drawing.Point(30, 67);
            idConsultaLabel.Name = "idConsultaLabel";
            idConsultaLabel.Size = new System.Drawing.Size(63, 13);
            idConsultaLabel.TabIndex = 2;
            idConsultaLabel.Text = "Id Consulta:";
            // 
            // idConsultaTextBox
            // 
            this.idConsultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosticosBindingSource, "IdConsulta", true));
            this.idConsultaTextBox.Location = new System.Drawing.Point(114, 64);
            this.idConsultaTextBox.Name = "idConsultaTextBox";
            this.idConsultaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idConsultaTextBox.TabIndex = 3;
            // 
            // idDiagnosticoLabel
            // 
            idDiagnosticoLabel.AutoSize = true;
            idDiagnosticoLabel.Location = new System.Drawing.Point(30, 93);
            idDiagnosticoLabel.Name = "idDiagnosticoLabel";
            idDiagnosticoLabel.Size = new System.Drawing.Size(78, 13);
            idDiagnosticoLabel.TabIndex = 4;
            idDiagnosticoLabel.Text = "Id Diagnostico:";
            // 
            // idDiagnosticoTextBox
            // 
            this.idDiagnosticoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosticosBindingSource, "IdDiagnostico", true));
            this.idDiagnosticoTextBox.Location = new System.Drawing.Point(114, 90);
            this.idDiagnosticoTextBox.Name = "idDiagnosticoTextBox";
            this.idDiagnosticoTextBox.Size = new System.Drawing.Size(100, 20);
            this.idDiagnosticoTextBox.TabIndex = 5;
            // 
            // recetasLabel
            // 
            recetasLabel.AutoSize = true;
            recetasLabel.Location = new System.Drawing.Point(30, 119);
            recetasLabel.Name = "recetasLabel";
            recetasLabel.Size = new System.Drawing.Size(50, 13);
            recetasLabel.TabIndex = 6;
            recetasLabel.Text = "Recetas:";
            // 
            // recetasTextBox
            // 
            this.recetasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosticosBindingSource, "Recetas", true));
            this.recetasTextBox.Location = new System.Drawing.Point(114, 116);
            this.recetasTextBox.Name = "recetasTextBox";
            this.recetasTextBox.Size = new System.Drawing.Size(100, 20);
            this.recetasTextBox.TabIndex = 7;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(45, 187);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(150, 187);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // RegistrarD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 222);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrarD";
            this.Text = "Registrar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox diagnosticoTextBox;
        private System.Windows.Forms.BindingSource diagnosticosBindingSource;
        private System.Windows.Forms.TextBox idConsultaTextBox;
        private System.Windows.Forms.TextBox idDiagnosticoTextBox;
        private System.Windows.Forms.TextBox recetasTextBox;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
    }
}