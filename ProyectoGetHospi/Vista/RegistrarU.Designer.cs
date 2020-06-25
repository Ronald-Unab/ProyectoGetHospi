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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grbRegistrar = new System.Windows.Forms.GroupBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.direcciónTextBox = new System.Windows.Forms.TextBox();
            this.dUITextBox = new System.Windows.Forms.TextBox();
            this.nITTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.usuariobindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            claveLabel.Location = new System.Drawing.Point(29, 170);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(37, 13);
            claveLabel.TabIndex = 0;
            claveLabel.Text = "Clave:";
            // 
            // direcciónLabel
            // 
            direcciónLabel.AutoSize = true;
            direcciónLabel.Location = new System.Drawing.Point(29, 66);
            direcciónLabel.Name = "direcciónLabel";
            direcciónLabel.Size = new System.Drawing.Size(55, 13);
            direcciónLabel.TabIndex = 2;
            direcciónLabel.Text = "Dirección:";
            // 
            // dUILabel
            // 
            dUILabel.AutoSize = true;
            dUILabel.Location = new System.Drawing.Point(29, 92);
            dUILabel.Name = "dUILabel";
            dUILabel.Size = new System.Drawing.Size(29, 13);
            dUILabel.TabIndex = 4;
            dUILabel.Text = "DUI:";
            // 
            // nITLabel
            // 
            nITLabel.AutoSize = true;
            nITLabel.Location = new System.Drawing.Point(29, 118);
            nITLabel.Name = "nITLabel";
            nITLabel.Size = new System.Drawing.Size(28, 13);
            nITLabel.TabIndex = 10;
            nITLabel.Text = "NIT:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(29, 40);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 12;
            nombreLabel.Text = "Nombre:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(29, 144);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(46, 13);
            usuarioLabel.TabIndex = 14;
            usuarioLabel.Text = "Usuario:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(29, 197);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 15;
            fechaLabel.Text = "Fecha:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(181, 331);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
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
            this.grbRegistrar.Location = new System.Drawing.Point(15, 49);
            this.grbRegistrar.Name = "grbRegistrar";
            this.grbRegistrar.Size = new System.Drawing.Size(346, 249);
            this.grbRegistrar.TabIndex = 14;
            this.grbRegistrar.TabStop = false;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.usuariobindingSource, "Fecha", true));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(93, 193);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 16;
            // 
            // claveTextBox
            // 
            this.claveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariobindingSource, "Clave", true));
            this.claveTextBox.Location = new System.Drawing.Point(93, 167);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.PasswordChar = '*';
            this.claveTextBox.Size = new System.Drawing.Size(200, 20);
            this.claveTextBox.TabIndex = 1;
            // 
            // direcciónTextBox
            // 
            this.direcciónTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariobindingSource, "Dirección", true));
            this.direcciónTextBox.Location = new System.Drawing.Point(93, 63);
            this.direcciónTextBox.Name = "direcciónTextBox";
            this.direcciónTextBox.Size = new System.Drawing.Size(200, 20);
            this.direcciónTextBox.TabIndex = 3;
            // 
            // dUITextBox
            // 
            this.dUITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariobindingSource, "DUI", true));
            this.dUITextBox.Location = new System.Drawing.Point(93, 89);
            this.dUITextBox.Name = "dUITextBox";
            this.dUITextBox.Size = new System.Drawing.Size(200, 20);
            this.dUITextBox.TabIndex = 5;
            // 
            // nITTextBox
            // 
            this.nITTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariobindingSource, "NIT", true));
            this.nITTextBox.Location = new System.Drawing.Point(93, 115);
            this.nITTextBox.Name = "nITTextBox";
            this.nITTextBox.Size = new System.Drawing.Size(200, 20);
            this.nITTextBox.TabIndex = 11;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariobindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(93, 37);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 13;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariobindingSource, "Usuario", true));
            this.usuarioTextBox.Location = new System.Drawing.Point(93, 141);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(200, 20);
            this.usuarioTextBox.TabIndex = 15;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(100, 331);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // usuariobindingSource
            // 
            this.usuariobindingSource.DataSource = typeof(ProyectoGetHospi.Entidades.Usuarios);
            // 
            // RegistrarU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 391);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grbRegistrar);
            this.Name = "RegistrarU";
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.RegistrarU_Load);
            this.grbRegistrar.ResumeLayout(false);
            this.grbRegistrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariobindingSource)).EndInit();
            this.ResumeLayout(false);

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
    }
}