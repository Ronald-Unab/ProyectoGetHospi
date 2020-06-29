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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarC));
            this.idArchivoTextBox = new System.Windows.Forms.TextBox();
            this.consultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idConsultaTextBox = new System.Windows.Forms.TextBox();
            this.idMedicoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            idArchivoLabel = new System.Windows.Forms.Label();
            idConsultaLabel = new System.Windows.Forms.Label();
            idMedicoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idArchivoLabel
            // 
            idArchivoLabel.AutoSize = true;
            idArchivoLabel.Enabled = false;
            idArchivoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idArchivoLabel.Location = new System.Drawing.Point(22, 35);
            idArchivoLabel.Name = "idArchivoLabel";
            idArchivoLabel.Size = new System.Drawing.Size(90, 20);
            idArchivoLabel.TabIndex = 1;
            idArchivoLabel.Text = "Id Archivo:";
            // 
            // idConsultaLabel
            // 
            idConsultaLabel.AutoSize = true;
            idConsultaLabel.Enabled = false;
            idConsultaLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idConsultaLabel.Location = new System.Drawing.Point(22, 61);
            idConsultaLabel.Name = "idConsultaLabel";
            idConsultaLabel.Size = new System.Drawing.Size(96, 20);
            idConsultaLabel.TabIndex = 3;
            idConsultaLabel.Text = "Id Consulta:";
            // 
            // idMedicoLabel
            // 
            idMedicoLabel.AutoSize = true;
            idMedicoLabel.Enabled = false;
            idMedicoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idMedicoLabel.Location = new System.Drawing.Point(22, 87);
            idMedicoLabel.Name = "idMedicoLabel";
            idMedicoLabel.Size = new System.Drawing.Size(90, 20);
            idMedicoLabel.TabIndex = 5;
            idMedicoLabel.Text = "Id Medico:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(22, 113);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(72, 20);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "Nombre:";
            // 
            // idArchivoTextBox
            // 
            this.idArchivoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idArchivoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "IdArchivo", true));
            this.idArchivoTextBox.Enabled = false;
            this.idArchivoTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idArchivoTextBox.Location = new System.Drawing.Point(139, 35);
            this.idArchivoTextBox.Name = "idArchivoTextBox";
            this.idArchivoTextBox.Size = new System.Drawing.Size(132, 19);
            this.idArchivoTextBox.TabIndex = 2;
            // 
            // idConsultaTextBox
            // 
            this.idConsultaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idConsultaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "IdConsulta", true));
            this.idConsultaTextBox.Enabled = false;
            this.idConsultaTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idConsultaTextBox.Location = new System.Drawing.Point(139, 61);
            this.idConsultaTextBox.Name = "idConsultaTextBox";
            this.idConsultaTextBox.Size = new System.Drawing.Size(132, 19);
            this.idConsultaTextBox.TabIndex = 4;
            // 
            // idMedicoTextBox
            // 
            this.idMedicoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idMedicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "IdMedico", true));
            this.idMedicoTextBox.Enabled = false;
            this.idMedicoTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idMedicoTextBox.Location = new System.Drawing.Point(139, 87);
            this.idMedicoTextBox.Name = "idMedicoTextBox";
            this.idMedicoTextBox.Size = new System.Drawing.Size(132, 19);
            this.idMedicoTextBox.TabIndex = 6;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(139, 113);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(132, 19);
            this.nombreTextBox.TabIndex = 8;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(376, 76);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(96, 33);
            this.btnNuevo.TabIndex = 9;
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
            this.btnGuardar.Location = new System.Drawing.Point(376, 132);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 31);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idMedicoTextBox);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(idArchivoLabel);
            this.groupBox1.Controls.Add(idMedicoLabel);
            this.groupBox1.Controls.Add(this.idArchivoTextBox);
            this.groupBox1.Controls.Add(this.idConsultaTextBox);
            this.groupBox1.Controls.Add(idConsultaLabel);
            this.groupBox1.Location = new System.Drawing.Point(27, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 155);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Registrar Consulta\r\n";
            // 
            // RegistrarC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(507, 219);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegistrarC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource consultasBindingSource;
        private System.Windows.Forms.TextBox idArchivoTextBox;
        private System.Windows.Forms.TextBox idConsultaTextBox;
        private System.Windows.Forms.TextBox idMedicoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
    }
}