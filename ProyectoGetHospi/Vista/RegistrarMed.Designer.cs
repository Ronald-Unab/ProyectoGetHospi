namespace ProyectoGetHospi.Vista
{
    partial class RegistrarMed
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
            System.Windows.Forms.Label cedulaMedicoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label dUILabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarMed));
            this.grbMed = new System.Windows.Forms.GroupBox();
            this.cedulaMedicoTextBox = new System.Windows.Forms.TextBox();
            this.médicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.dUITextBox = new System.Windows.Forms.TextBox();
            this.btnNuevoMed = new System.Windows.Forms.Button();
            this.btnGuardarMed = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            cedulaMedicoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            dUILabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            this.grbMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.médicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cedulaMedicoLabel
            // 
            cedulaMedicoLabel.AutoSize = true;
            cedulaMedicoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cedulaMedicoLabel.Location = new System.Drawing.Point(13, 21);
            cedulaMedicoLabel.Name = "cedulaMedicoLabel";
            cedulaMedicoLabel.Size = new System.Drawing.Size(129, 20);
            cedulaMedicoLabel.TabIndex = 0;
            cedulaMedicoLabel.Text = "Cedula Medico:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(16, 73);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(84, 20);
            direccionLabel.TabIndex = 2;
            direccionLabel.Text = "Direccion:";
            // 
            // dUILabel
            // 
            dUILabel.AutoSize = true;
            dUILabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dUILabel.Location = new System.Drawing.Point(16, 99);
            dUILabel.Name = "dUILabel";
            dUILabel.Size = new System.Drawing.Size(40, 20);
            dUILabel.TabIndex = 4;
            dUILabel.Text = "DUI:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(16, 47);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(72, 20);
            nombreLabel.TabIndex = 8;
            nombreLabel.Text = "Nombre:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.Location = new System.Drawing.Point(16, 121);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(75, 20);
            telefonoLabel.TabIndex = 10;
            telefonoLabel.Text = "Telefono:";
            // 
            // grbMed
            // 
            this.grbMed.Controls.Add(cedulaMedicoLabel);
            this.grbMed.Controls.Add(this.cedulaMedicoTextBox);
            this.grbMed.Controls.Add(direccionLabel);
            this.grbMed.Controls.Add(telefonoLabel);
            this.grbMed.Controls.Add(dUILabel);
            this.grbMed.Controls.Add(this.telefonoTextBox);
            this.grbMed.Controls.Add(this.direccionTextBox);
            this.grbMed.Controls.Add(this.nombreTextBox);
            this.grbMed.Controls.Add(nombreLabel);
            this.grbMed.Controls.Add(this.dUITextBox);
            this.grbMed.Location = new System.Drawing.Point(27, 45);
            this.grbMed.Name = "grbMed";
            this.grbMed.Size = new System.Drawing.Size(324, 155);
            this.grbMed.TabIndex = 0;
            this.grbMed.TabStop = false;
            // 
            // cedulaMedicoTextBox
            // 
            this.cedulaMedicoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cedulaMedicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "CedulaMedico", true));
            this.cedulaMedicoTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedulaMedicoTextBox.Location = new System.Drawing.Point(162, 21);
            this.cedulaMedicoTextBox.Name = "cedulaMedicoTextBox";
            this.cedulaMedicoTextBox.Size = new System.Drawing.Size(131, 19);
            this.cedulaMedicoTextBox.TabIndex = 1;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "Telefono", true));
            this.telefonoTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoTextBox.Location = new System.Drawing.Point(162, 123);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(131, 19);
            this.telefonoTextBox.TabIndex = 11;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "Direccion", true));
            this.direccionTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(162, 99);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(131, 19);
            this.direccionTextBox.TabIndex = 3;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(162, 47);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(131, 19);
            this.nombreTextBox.TabIndex = 9;
            // 
            // dUITextBox
            // 
            this.dUITextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dUITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "DUI", true));
            this.dUITextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dUITextBox.Location = new System.Drawing.Point(162, 73);
            this.dUITextBox.Name = "dUITextBox";
            this.dUITextBox.Size = new System.Drawing.Size(131, 19);
            this.dUITextBox.TabIndex = 5;
            // 
            // btnNuevoMed
            // 
            this.btnNuevoMed.Location = new System.Drawing.Point(82, 225);
            this.btnNuevoMed.Name = "btnNuevoMed";
            this.btnNuevoMed.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoMed.TabIndex = 1;
            this.btnNuevoMed.Text = "Nuevo";
            this.btnNuevoMed.UseVisualStyleBackColor = true;
            // 
            // btnGuardarMed
            // 
            this.btnGuardarMed.Location = new System.Drawing.Point(166, 224);
            this.btnGuardarMed.Name = "btnGuardarMed";
            this.btnGuardarMed.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarMed.TabIndex = 2;
            this.btnGuardarMed.Text = "Guardar";
            this.btnGuardarMed.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(385, 137);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(95, 37);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(385, 76);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(95, 36);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Registrar Médico";
            // 
            // RegistrarMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(507, 219);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardarMed);
            this.Controls.Add(this.btnNuevoMed);
            this.Controls.Add(this.grbMed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegistrarMed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.RegistrarMed_Load);
            this.grbMed.ResumeLayout(false);
            this.grbMed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.médicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbMed;
        private System.Windows.Forms.TextBox cedulaMedicoTextBox;
        private System.Windows.Forms.BindingSource médicoBindingSource;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox dUITextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.Button btnNuevoMed;
        private System.Windows.Forms.Button btnGuardarMed;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
    }
}