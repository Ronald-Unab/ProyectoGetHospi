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
            this.grbMed = new System.Windows.Forms.GroupBox();
            this.cedulaMedicoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.dUITextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.btnNuevoMed = new System.Windows.Forms.Button();
            this.btnGuardarMed = new System.Windows.Forms.Button();
            this.médicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            cedulaMedicoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            dUILabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            this.grbMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.médicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbMed
            // 
            this.grbMed.Controls.Add(cedulaMedicoLabel);
            this.grbMed.Controls.Add(this.cedulaMedicoTextBox);
            this.grbMed.Controls.Add(direccionLabel);
            this.grbMed.Controls.Add(this.direccionTextBox);
            this.grbMed.Controls.Add(dUILabel);
            this.grbMed.Controls.Add(this.dUITextBox);
            this.grbMed.Controls.Add(nombreLabel);
            this.grbMed.Controls.Add(this.nombreTextBox);
            this.grbMed.Controls.Add(telefonoLabel);
            this.grbMed.Controls.Add(this.telefonoTextBox);
            this.grbMed.Location = new System.Drawing.Point(12, 12);
            this.grbMed.Name = "grbMed";
            this.grbMed.Size = new System.Drawing.Size(317, 206);
            this.grbMed.TabIndex = 0;
            this.grbMed.TabStop = false;
            // 
            // cedulaMedicoLabel
            // 
            cedulaMedicoLabel.AutoSize = true;
            cedulaMedicoLabel.Location = new System.Drawing.Point(47, 53);
            cedulaMedicoLabel.Name = "cedulaMedicoLabel";
            cedulaMedicoLabel.Size = new System.Drawing.Size(81, 13);
            cedulaMedicoLabel.TabIndex = 0;
            cedulaMedicoLabel.Text = "Cedula Medico:";
            // 
            // cedulaMedicoTextBox
            // 
            this.cedulaMedicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "CedulaMedico", true));
            this.cedulaMedicoTextBox.Location = new System.Drawing.Point(134, 50);
            this.cedulaMedicoTextBox.Name = "cedulaMedicoTextBox";
            this.cedulaMedicoTextBox.Size = new System.Drawing.Size(100, 20);
            this.cedulaMedicoTextBox.TabIndex = 1;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(47, 79);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 2;
            direccionLabel.Text = "Direccion:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(134, 102);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox.TabIndex = 3;
            // 
            // dUILabel
            // 
            dUILabel.AutoSize = true;
            dUILabel.Location = new System.Drawing.Point(47, 105);
            dUILabel.Name = "dUILabel";
            dUILabel.Size = new System.Drawing.Size(29, 13);
            dUILabel.TabIndex = 4;
            dUILabel.Text = "DUI:";
            // 
            // dUITextBox
            // 
            this.dUITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "DUI", true));
            this.dUITextBox.Location = new System.Drawing.Point(134, 76);
            this.dUITextBox.Name = "dUITextBox";
            this.dUITextBox.Size = new System.Drawing.Size(100, 20);
            this.dUITextBox.TabIndex = 5;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(47, 131);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 8;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(134, 128);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 9;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(47, 157);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 10;
            telefonoLabel.Text = "Telefono:";
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.médicoBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(134, 154);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 11;
            // 
            // btnNuevoMed
            // 
            this.btnNuevoMed.Location = new System.Drawing.Point(82, 225);
            this.btnNuevoMed.Name = "btnNuevoMed";
            this.btnNuevoMed.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoMed.TabIndex = 1;
            this.btnNuevoMed.Text = "Nuevo";
            this.btnNuevoMed.UseVisualStyleBackColor = true;
            this.btnNuevoMed.Click += new System.EventHandler(this.btnNuevoMed_Click);
            // 
            // btnGuardarMed
            // 
            this.btnGuardarMed.Location = new System.Drawing.Point(166, 224);
            this.btnGuardarMed.Name = "btnGuardarMed";
            this.btnGuardarMed.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarMed.TabIndex = 2;
            this.btnGuardarMed.Text = "Guardar";
            this.btnGuardarMed.UseVisualStyleBackColor = true;
            this.btnGuardarMed.Click += new System.EventHandler(this.btnGuardarMed_Click);
            // 
            // médicoBindingSource
            // 
            this.médicoBindingSource.DataSource = typeof(ProyectoGetHospi.Entidades.Médico);
            // 
            // RegistrarMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 265);
            this.Controls.Add(this.btnGuardarMed);
            this.Controls.Add(this.btnNuevoMed);
            this.Controls.Add(this.grbMed);
            this.Name = "RegistrarMed";
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.RegistrarMed_Load);
            this.grbMed.ResumeLayout(false);
            this.grbMed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.médicoBindingSource)).EndInit();
            this.ResumeLayout(false);

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
    }
}