namespace ProyectoGetHospi.Vista
{
    partial class fMenu
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
            this.btnMedicosMe = new System.Windows.Forms.Button();
            this.btnUsuariosM = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnArchivos = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnDiagnostico = new System.Windows.Forms.Button();
            this.btnEspecialidades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMedicosMe
            // 
            this.btnMedicosMe.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicosMe.Location = new System.Drawing.Point(10, 31);
            this.btnMedicosMe.Name = "btnMedicosMe";
            this.btnMedicosMe.Size = new System.Drawing.Size(260, 47);
            this.btnMedicosMe.TabIndex = 0;
            this.btnMedicosMe.Text = "Medicos";
            this.btnMedicosMe.UseVisualStyleBackColor = true;
            this.btnMedicosMe.Click += new System.EventHandler(this.btnMedicosM);
            // 
            // btnUsuariosM
            // 
            this.btnUsuariosM.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuariosM.Location = new System.Drawing.Point(10, 84);
            this.btnUsuariosM.Name = "btnUsuariosM";
            this.btnUsuariosM.Size = new System.Drawing.Size(260, 47);
            this.btnUsuariosM.TabIndex = 1;
            this.btnUsuariosM.Text = "Usuarios";
            this.btnUsuariosM.UseVisualStyleBackColor = true;
            this.btnUsuariosM.Click += new System.EventHandler(this.btnUsuarios);
            // 
            // btnPacientes
            // 
            this.btnPacientes.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.Location = new System.Drawing.Point(10, 137);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(260, 46);
            this.btnPacientes.TabIndex = 2;
            this.btnPacientes.Text = "Pacientes";
            this.btnPacientes.UseVisualStyleBackColor = true;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnArchivos
            // 
            this.btnArchivos.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchivos.Location = new System.Drawing.Point(10, 189);
            this.btnArchivos.Name = "btnArchivos";
            this.btnArchivos.Size = new System.Drawing.Size(260, 45);
            this.btnArchivos.TabIndex = 3;
            this.btnArchivos.Text = "Archivos";
            this.btnArchivos.UseVisualStyleBackColor = true;
            this.btnArchivos.Click += new System.EventHandler(this.btnArchivos_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Location = new System.Drawing.Point(10, 240);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(260, 44);
            this.btnConsulta.TabIndex = 4;
            this.btnConsulta.Text = "Consultas";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnDiagnostico
            // 
            this.btnDiagnostico.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnostico.Location = new System.Drawing.Point(10, 290);
            this.btnDiagnostico.Name = "btnDiagnostico";
            this.btnDiagnostico.Size = new System.Drawing.Size(260, 47);
            this.btnDiagnostico.TabIndex = 5;
            this.btnDiagnostico.Text = "Diagnostico";
            this.btnDiagnostico.UseVisualStyleBackColor = true;
            this.btnDiagnostico.Click += new System.EventHandler(this.btnDiagnostico_Click);
            // 
            // btnEspecialidades
            // 
            this.btnEspecialidades.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspecialidades.Location = new System.Drawing.Point(10, 343);
            this.btnEspecialidades.Name = "btnEspecialidades";
            this.btnEspecialidades.Size = new System.Drawing.Size(260, 47);
            this.btnEspecialidades.TabIndex = 6;
            this.btnEspecialidades.Text = "Especialidades";
            this.btnEspecialidades.UseVisualStyleBackColor = true;
            this.btnEspecialidades.Click += new System.EventHandler(this.btnEspecialidades_Click);
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 401);
            this.Controls.Add(this.btnEspecialidades);
            this.Controls.Add(this.btnDiagnostico);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnArchivos);
            this.Controls.Add(this.btnPacientes);
            this.Controls.Add(this.btnUsuariosM);
            this.Controls.Add(this.btnMedicosMe);
            this.Name = "fMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMedicosMe;
        private System.Windows.Forms.Button btnUsuariosM;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnArchivos;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnDiagnostico;
        private System.Windows.Forms.Button btnEspecialidades;
    }
}