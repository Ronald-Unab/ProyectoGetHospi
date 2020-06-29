namespace ProyectoGetHospi.Vista
{
    partial class RegistrarE
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
            System.Windows.Forms.Label idEspecialidadLabel;
            System.Windows.Forms.Label idMedicoLabel;
            System.Windows.Forms.Label nombreLabel;
            this.especialidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idEspecialidadTextBox = new System.Windows.Forms.TextBox();
            this.idMedicoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            idEspecialidadLabel = new System.Windows.Forms.Label();
            idMedicoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // especialidadesBindingSource
            // 
            //this.especialidadesBindingSource.DataSource = typeof(ProyectoGetHospi.Entidades.Especialidades);
            // 
            // idEspecialidadLabel
            // 
            idEspecialidadLabel.AutoSize = true;
            idEspecialidadLabel.Location = new System.Drawing.Point(16, 56);
            idEspecialidadLabel.Name = "idEspecialidadLabel";
            idEspecialidadLabel.Size = new System.Drawing.Size(81, 13);
            idEspecialidadLabel.TabIndex = 1;
            idEspecialidadLabel.Text = "id Especialidad:";
            // 
            // idEspecialidadTextBox
            // 
            this.idEspecialidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.especialidadesBindingSource, "idEspecialidad", true));
            this.idEspecialidadTextBox.Location = new System.Drawing.Point(103, 53);
            this.idEspecialidadTextBox.Name = "idEspecialidadTextBox";
            this.idEspecialidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.idEspecialidadTextBox.TabIndex = 2;
            // 
            // idMedicoLabel
            // 
            idMedicoLabel.AutoSize = true;
            idMedicoLabel.Location = new System.Drawing.Point(16, 82);
            idMedicoLabel.Name = "idMedicoLabel";
            idMedicoLabel.Size = new System.Drawing.Size(56, 13);
            idMedicoLabel.TabIndex = 3;
            idMedicoLabel.Text = "id Medico:";
            // 
            // idMedicoTextBox
            // 
            this.idMedicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.especialidadesBindingSource, "idMedico", true));
            this.idMedicoTextBox.Location = new System.Drawing.Point(103, 79);
            this.idMedicoTextBox.Name = "idMedicoTextBox";
            this.idMedicoTextBox.Size = new System.Drawing.Size(100, 20);
            this.idMedicoTextBox.TabIndex = 4;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(16, 108);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.especialidadesBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(103, 105);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // RegistrarE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 205);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(idEspecialidadLabel);
            this.Controls.Add(this.idEspecialidadTextBox);
            this.Controls.Add(idMedicoLabel);
            this.Controls.Add(this.idMedicoTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Name = "RegistrarE";
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.RegistrarE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource especialidadesBindingSource;
        private System.Windows.Forms.TextBox idEspecialidadTextBox;
        private System.Windows.Forms.TextBox idMedicoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}