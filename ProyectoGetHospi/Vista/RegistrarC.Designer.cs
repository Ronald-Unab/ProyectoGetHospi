namespace ProyectoGetHospi.Vista
{
    partial class RegistrarC
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
            System.Windows.Forms.Label idConsultaLabel;
            System.Windows.Forms.Label idMedicoLabel;
            System.Windows.Forms.Label nombreLabel;
            this.idArchivoTextBox = new System.Windows.Forms.TextBox();
            this.idConsultaTextBox = new System.Windows.Forms.TextBox();
            this.idMedicoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.consultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idArchivoLabel = new System.Windows.Forms.Label();
            idConsultaLabel = new System.Windows.Forms.Label();
            idMedicoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idArchivoLabel
            // 
            idArchivoLabel.AutoSize = true;
            idArchivoLabel.Enabled = false;
            idArchivoLabel.Location = new System.Drawing.Point(69, 77);
            idArchivoLabel.Name = "idArchivoLabel";
            idArchivoLabel.Size = new System.Drawing.Size(58, 13);
            idArchivoLabel.TabIndex = 1;
            idArchivoLabel.Text = "Id Archivo:";
            // 
            // idArchivoTextBox
            // 
            this.idArchivoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "IdArchivo", true));
            this.idArchivoTextBox.Enabled = false;
            this.idArchivoTextBox.Location = new System.Drawing.Point(138, 74);
            this.idArchivoTextBox.Name = "idArchivoTextBox";
            this.idArchivoTextBox.Size = new System.Drawing.Size(100, 20);
            this.idArchivoTextBox.TabIndex = 2;
            // 
            // idConsultaLabel
            // 
            idConsultaLabel.AutoSize = true;
            idConsultaLabel.Enabled = false;
            idConsultaLabel.Location = new System.Drawing.Point(69, 103);
            idConsultaLabel.Name = "idConsultaLabel";
            idConsultaLabel.Size = new System.Drawing.Size(63, 13);
            idConsultaLabel.TabIndex = 3;
            idConsultaLabel.Text = "Id Consulta:";
            // 
            // idConsultaTextBox
            // 
            this.idConsultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "IdConsulta", true));
            this.idConsultaTextBox.Enabled = false;
            this.idConsultaTextBox.Location = new System.Drawing.Point(138, 100);
            this.idConsultaTextBox.Name = "idConsultaTextBox";
            this.idConsultaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idConsultaTextBox.TabIndex = 4;
            // 
            // idMedicoLabel
            // 
            idMedicoLabel.AutoSize = true;
            idMedicoLabel.Enabled = false;
            idMedicoLabel.Location = new System.Drawing.Point(69, 129);
            idMedicoLabel.Name = "idMedicoLabel";
            idMedicoLabel.Size = new System.Drawing.Size(57, 13);
            idMedicoLabel.TabIndex = 5;
            idMedicoLabel.Text = "Id Medico:";
            // 
            // idMedicoTextBox
            // 
            this.idMedicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "IdMedico", true));
            this.idMedicoTextBox.Enabled = false;
            this.idMedicoTextBox.Location = new System.Drawing.Point(138, 126);
            this.idMedicoTextBox.Name = "idMedicoTextBox";
            this.idMedicoTextBox.Size = new System.Drawing.Size(100, 20);
            this.idMedicoTextBox.TabIndex = 6;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(69, 155);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(138, 152);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 8;
            // 
            // consultasBindingSource
            // 
            this.consultasBindingSource.DataSource = typeof(ProyectoGetHospi.Entidades.Consultas);
            // 
            // RegistrarC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 290);
            this.Controls.Add(idArchivoLabel);
            this.Controls.Add(this.idArchivoTextBox);
            this.Controls.Add(idConsultaLabel);
            this.Controls.Add(this.idConsultaTextBox);
            this.Controls.Add(idMedicoLabel);
            this.Controls.Add(this.idMedicoTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Name = "RegistrarC";
            this.Text = "Registrar";
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource consultasBindingSource;
        private System.Windows.Forms.TextBox idArchivoTextBox;
        private System.Windows.Forms.TextBox idConsultaTextBox;
        private System.Windows.Forms.TextBox idMedicoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
    }
}