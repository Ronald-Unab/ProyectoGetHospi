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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarD));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.diagnosticoTextBox = new System.Windows.Forms.TextBox();
            this.diagnosticosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idConsultaTextBox = new System.Windows.Forms.TextBox();
            this.idDiagnosticoTextBox = new System.Windows.Forms.TextBox();
            this.recetasTextBox = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            diagnosticoLabel = new System.Windows.Forms.Label();
            idConsultaLabel = new System.Windows.Forms.Label();
            idDiagnosticoLabel = new System.Windows.Forms.Label();
            recetasLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // diagnosticoLabel
            // 
            diagnosticoLabel.AutoSize = true;
            diagnosticoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            diagnosticoLabel.Location = new System.Drawing.Point(19, 84);
            diagnosticoLabel.Name = "diagnosticoLabel";
            diagnosticoLabel.Size = new System.Drawing.Size(100, 20);
            diagnosticoLabel.TabIndex = 0;
            diagnosticoLabel.Text = "Diagnostico:";
            // 
            // idConsultaLabel
            // 
            idConsultaLabel.AutoSize = true;
            idConsultaLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idConsultaLabel.Location = new System.Drawing.Point(19, 58);
            idConsultaLabel.Name = "idConsultaLabel";
            idConsultaLabel.Size = new System.Drawing.Size(96, 20);
            idConsultaLabel.TabIndex = 2;
            idConsultaLabel.Text = "Id Consulta:";
            // 
            // idDiagnosticoLabel
            // 
            idDiagnosticoLabel.AutoSize = true;
            idDiagnosticoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idDiagnosticoLabel.Location = new System.Drawing.Point(19, 32);
            idDiagnosticoLabel.Name = "idDiagnosticoLabel";
            idDiagnosticoLabel.Size = new System.Drawing.Size(119, 20);
            idDiagnosticoLabel.TabIndex = 4;
            idDiagnosticoLabel.Text = "Id Diagnostico:";
            // 
            // recetasLabel
            // 
            recetasLabel.AutoSize = true;
            recetasLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            recetasLabel.Location = new System.Drawing.Point(19, 110);
            recetasLabel.Name = "recetasLabel";
            recetasLabel.Size = new System.Drawing.Size(73, 20);
            recetasLabel.TabIndex = 6;
            recetasLabel.Text = "Recetas:";
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
            this.groupBox1.Location = new System.Drawing.Point(27, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // diagnosticoTextBox
            // 
            this.diagnosticoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diagnosticoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosticosBindingSource, "Diagnostico", true));
            this.diagnosticoTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagnosticoTextBox.Location = new System.Drawing.Point(150, 84);
            this.diagnosticoTextBox.Name = "diagnosticoTextBox";
            this.diagnosticoTextBox.Size = new System.Drawing.Size(148, 19);
            this.diagnosticoTextBox.TabIndex = 1;
            // 
            // idConsultaTextBox
            // 
            this.idConsultaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idConsultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosticosBindingSource, "IdConsulta", true));
            this.idConsultaTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idConsultaTextBox.Location = new System.Drawing.Point(150, 58);
            this.idConsultaTextBox.Name = "idConsultaTextBox";
            this.idConsultaTextBox.Size = new System.Drawing.Size(148, 19);
            this.idConsultaTextBox.TabIndex = 3;
            // 
            // idDiagnosticoTextBox
            // 
            this.idDiagnosticoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idDiagnosticoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosticosBindingSource, "IdDiagnostico", true));
            this.idDiagnosticoTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idDiagnosticoTextBox.Location = new System.Drawing.Point(150, 32);
            this.idDiagnosticoTextBox.Name = "idDiagnosticoTextBox";
            this.idDiagnosticoTextBox.Size = new System.Drawing.Size(148, 19);
            this.idDiagnosticoTextBox.TabIndex = 5;
            // 
            // recetasTextBox
            // 
            this.recetasTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recetasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diagnosticosBindingSource, "Recetas", true));
            this.recetasTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recetasTextBox.Location = new System.Drawing.Point(150, 110);
            this.recetasTextBox.Name = "recetasTextBox";
            this.recetasTextBox.Size = new System.Drawing.Size(148, 19);
            this.recetasTextBox.TabIndex = 7;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(380, 77);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(93, 35);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(380, 129);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 35);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Registrar Diagnostico\r\n";
            // 
            // RegistrarD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(507, 219);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegistrarD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.RegistrarD_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
    }
}