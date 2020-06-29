namespace ProyectoGetHospi.Vista
{
    partial class RegistrarU
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
            System.Windows.Forms.Label claveLabel;
            System.Windows.Forms.Label direcciónLabel;
            System.Windows.Forms.Label dUILabel;
            System.Windows.Forms.Label nITLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label fechaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarU));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grbRegistrar = new System.Windows.Forms.GroupBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.usuariobindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.direcciónTextBox = new System.Windows.Forms.TextBox();
            this.dUITextBox = new System.Windows.Forms.TextBox();
            this.nITTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            claveLabel = new System.Windows.Forms.Label();
            direcciónLabel = new System.Windows.Forms.Label();
            dUILabel = new System.Windows.Forms.Label();
            nITLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            this.grbRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariobindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            claveLabel.Location = new System.Drawing.Point(29, 159);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(58, 20);
            claveLabel.TabIndex = 0;
            claveLabel.Text = "Clave:";
            // 
            // direcciónLabel
            // 
            direcciónLabel.AutoSize = true;
            direcciónLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direcciónLabel.Location = new System.Drawing.Point(29, 56);
            direcciónLabel.Name = "direcciónLabel";
            direcciónLabel.Size = new System.Drawing.Size(84, 20);
            direcciónLabel.TabIndex = 2;
            direcciónLabel.Text = "Dirección:";
            // 
            // dUILabel
            // 
            dUILabel.AutoSize = true;
            dUILabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dUILabel.Location = new System.Drawing.Point(29, 81);
            dUILabel.Name = "dUILabel";
            dUILabel.Size = new System.Drawing.Size(40, 20);
            dUILabel.TabIndex = 4;
            dUILabel.Text = "DUI:";
            // 
            // nITLabel
            // 
            nITLabel.AutoSize = true;
            nITLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nITLabel.Location = new System.Drawing.Point(29, 107);
            nITLabel.Name = "nITLabel";
            nITLabel.Size = new System.Drawing.Size(34, 20);
            nITLabel.TabIndex = 10;
            nITLabel.Text = "NIT:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(29, 29);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(72, 20);
            nombreLabel.TabIndex = 12;
            nombreLabel.Text = "Nombre:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuarioLabel.Location = new System.Drawing.Point(29, 133);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(67, 20);
            usuarioLabel.TabIndex = 14;
            usuarioLabel.Text = "Usuario:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.Location = new System.Drawing.Point(29, 186);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(59, 20);
            fechaLabel.TabIndex = 15;
            fechaLabel.Text = "Fecha:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(461, 176);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 33);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grbRegistrar
            // 
            this.grbRegistrar.Controls.Add(fechaLabel);
            this.grbRegistrar.Controls.Add(this.fechaDateTimePicker);
            this.grbRegistrar.Controls.Add(claveLabel);
            this.grbRegistrar.Controls.Add(this.claveTextBox);
            this.grbRegistrar.Controls.Add(direcciónLabel);
            this.grbRegistrar.Controls.Add(this.direcciónTextBox);
            this.grbRegistrar.Controls.Add(dUILabel);
            this.grbRegistrar.Controls.Add(this.dUITextBox);
            this.grbRegistrar.Controls.Add(nITLabel);
            this.grbRegistrar.Controls.Add(this.nITTextBox);
            this.grbRegistrar.Controls.Add(nombreLabel);
            this.grbRegistrar.Controls.Add(this.nombreTextBox);
            this.grbRegistrar.Controls.Add(usuarioLabel);
            this.grbRegistrar.Controls.Add(this.usuarioTextBox);
            this.grbRegistrar.Location = new System.Drawing.Point(36, 48);
            this.grbRegistrar.Name = "grbRegistrar";
            this.grbRegistrar.Size = new System.Drawing.Size(399, 230);
            this.grbRegistrar.TabIndex = 14;
            this.grbRegistrar.TabStop = false;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usuariobindingSource, "Fecha", true));
            this.fechaDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(157, 185);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(191, 22);
            this.fechaDateTimePicker.TabIndex = 16;
            // 
            // claveTextBox
            // 
            this.claveTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.claveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariobindingSource, "Clave", true));
            this.claveTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claveTextBox.Location = new System.Drawing.Point(157, 159);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.PasswordChar = '*';
            this.claveTextBox.Size = new System.Drawing.Size(191, 19);
            this.claveTextBox.TabIndex = 1;
            // 
            // direcciónTextBox
            // 
            this.direcciónTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.direcciónTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariobindingSource, "Dirección", true));
            this.direcciónTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direcciónTextBox.Location = new System.Drawing.Point(157, 55);
            this.direcciónTextBox.Name = "direcciónTextBox";
            this.direcciónTextBox.Size = new System.Drawing.Size(191, 19);
            this.direcciónTextBox.TabIndex = 3;
            // 
            // dUITextBox
            // 
            this.dUITextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dUITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariobindingSource, "DUI", true));
            this.dUITextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dUITextBox.Location = new System.Drawing.Point(157, 81);
            this.dUITextBox.Name = "dUITextBox";
            this.dUITextBox.Size = new System.Drawing.Size(191, 19);
            this.dUITextBox.TabIndex = 5;
            // 
            // nITTextBox
            // 
            this.nITTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nITTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariobindingSource, "NIT", true));
            this.nITTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nITTextBox.Location = new System.Drawing.Point(157, 107);
            this.nITTextBox.Name = "nITTextBox";
            this.nITTextBox.Size = new System.Drawing.Size(191, 19);
            this.nITTextBox.TabIndex = 11;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariobindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(157, 29);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(191, 19);
            this.nombreTextBox.TabIndex = 13;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariobindingSource, "Usuario", true));
            this.usuarioTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTextBox.Location = new System.Drawing.Point(157, 133);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(191, 19);
            this.usuarioTextBox.TabIndex = 15;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(461, 113);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(97, 31);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Registrar Usuario";
            // 
            // RegistrarU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(588, 295);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grbRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegistrarU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.RegistrarU_Load);
            this.grbRegistrar.ResumeLayout(false);
            this.grbRegistrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariobindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox grbRegistrar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.BindingSource usuariobindingSource;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.TextBox direcciónTextBox;
        private System.Windows.Forms.TextBox dUITextBox;
        private System.Windows.Forms.TextBox nITTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.Label label1;
    }
}