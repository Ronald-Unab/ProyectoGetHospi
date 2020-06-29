namespace ProyectoGetHospi.Vista
{
    partial class ActualizarA
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
            System.Windows.Forms.Label idPacienteLabel;
            System.Windows.Forms.Label pesoLabel;
            System.Windows.Forms.Label presionArterialLabel;
            System.Windows.Forms.Label temperaturaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarA));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idArchivoTextBox = new System.Windows.Forms.TextBox();
            this.archivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idPacienteTextBox = new System.Windows.Forms.TextBox();
            this.pesoTextBox = new System.Windows.Forms.TextBox();
            this.presionArterialTextBox = new System.Windows.Forms.TextBox();
            this.temperaturaTextBox = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.archivoDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            idArchivoLabel = new System.Windows.Forms.Label();
            idPacienteLabel = new System.Windows.Forms.Label();
            pesoLabel = new System.Windows.Forms.Label();
            presionArterialLabel = new System.Windows.Forms.Label();
            temperaturaLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idArchivoLabel
            // 
            idArchivoLabel.AutoSize = true;
            idArchivoLabel.Enabled = false;
            idArchivoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idArchivoLabel.Location = new System.Drawing.Point(6, 21);
            idArchivoLabel.Name = "idArchivoLabel";
            idArchivoLabel.Size = new System.Drawing.Size(90, 20);
            idArchivoLabel.TabIndex = 0;
            idArchivoLabel.Text = "Id Archivo:";
            // 
            // idPacienteLabel
            // 
            idPacienteLabel.AutoSize = true;
            idPacienteLabel.Enabled = false;
            idPacienteLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idPacienteLabel.Location = new System.Drawing.Point(6, 51);
            idPacienteLabel.Name = "idPacienteLabel";
            idPacienteLabel.Size = new System.Drawing.Size(98, 20);
            idPacienteLabel.TabIndex = 2;
            idPacienteLabel.Text = "Id Paciente:";
            // 
            // pesoLabel
            // 
            pesoLabel.AutoSize = true;
            pesoLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pesoLabel.Location = new System.Drawing.Point(6, 83);
            pesoLabel.Name = "pesoLabel";
            pesoLabel.Size = new System.Drawing.Size(48, 20);
            pesoLabel.TabIndex = 4;
            pesoLabel.Text = "Peso:";
            pesoLabel.Click += new System.EventHandler(this.pesoLabel_Click);
            // 
            // presionArterialLabel
            // 
            presionArterialLabel.AutoSize = true;
            presionArterialLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            presionArterialLabel.Location = new System.Drawing.Point(6, 114);
            presionArterialLabel.Name = "presionArterialLabel";
            presionArterialLabel.Size = new System.Drawing.Size(121, 20);
            presionArterialLabel.TabIndex = 6;
            presionArterialLabel.Text = "Presion Arterial:";
            // 
            // temperaturaLabel
            // 
            temperaturaLabel.AutoSize = true;
            temperaturaLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            temperaturaLabel.Location = new System.Drawing.Point(6, 146);
            temperaturaLabel.Name = "temperaturaLabel";
            temperaturaLabel.Size = new System.Drawing.Size(105, 20);
            temperaturaLabel.TabIndex = 8;
            temperaturaLabel.Text = "Temperatura:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idArchivoLabel);
            this.groupBox1.Controls.Add(this.idArchivoTextBox);
            this.groupBox1.Controls.Add(idPacienteLabel);
            this.groupBox1.Controls.Add(this.idPacienteTextBox);
            this.groupBox1.Controls.Add(pesoLabel);
            this.groupBox1.Controls.Add(this.pesoTextBox);
            this.groupBox1.Controls.Add(presionArterialLabel);
            this.groupBox1.Controls.Add(this.presionArterialTextBox);
            this.groupBox1.Controls.Add(temperaturaLabel);
            this.groupBox1.Controls.Add(this.temperaturaTextBox);
            this.groupBox1.Location = new System.Drawing.Point(504, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 182);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // idArchivoTextBox
            // 
            this.idArchivoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idArchivoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.archivoBindingSource, "IdArchivo", true));
            this.idArchivoTextBox.Enabled = false;
            this.idArchivoTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idArchivoTextBox.Location = new System.Drawing.Point(133, 23);
            this.idArchivoTextBox.Name = "idArchivoTextBox";
            this.idArchivoTextBox.Size = new System.Drawing.Size(113, 19);
            this.idArchivoTextBox.TabIndex = 1;
            // 
            // idPacienteTextBox
            // 
            this.idPacienteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idPacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.archivoBindingSource, "IdPaciente", true));
            this.idPacienteTextBox.Enabled = false;
            this.idPacienteTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPacienteTextBox.Location = new System.Drawing.Point(133, 53);
            this.idPacienteTextBox.Name = "idPacienteTextBox";
            this.idPacienteTextBox.Size = new System.Drawing.Size(113, 19);
            this.idPacienteTextBox.TabIndex = 3;
            // 
            // pesoTextBox
            // 
            this.pesoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pesoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.archivoBindingSource, "Peso", true));
            this.pesoTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesoTextBox.Location = new System.Drawing.Point(133, 83);
            this.pesoTextBox.Name = "pesoTextBox";
            this.pesoTextBox.Size = new System.Drawing.Size(113, 19);
            this.pesoTextBox.TabIndex = 5;
            // 
            // presionArterialTextBox
            // 
            this.presionArterialTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.presionArterialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.archivoBindingSource, "PresionArterial", true));
            this.presionArterialTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presionArterialTextBox.Location = new System.Drawing.Point(133, 114);
            this.presionArterialTextBox.Name = "presionArterialTextBox";
            this.presionArterialTextBox.Size = new System.Drawing.Size(113, 19);
            this.presionArterialTextBox.TabIndex = 7;
            // 
            // temperaturaTextBox
            // 
            this.temperaturaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.temperaturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.archivoBindingSource, "Temperatura", true));
            this.temperaturaTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperaturaTextBox.Location = new System.Drawing.Point(133, 148);
            this.temperaturaTextBox.Name = "temperaturaTextBox";
            this.temperaturaTextBox.Size = new System.Drawing.Size(113, 19);
            this.temperaturaTextBox.TabIndex = 9;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.Location = new System.Drawing.Point(207, 297);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(113, 34);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(606, 273);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 34);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // archivoDataGridView
            // 
            this.archivoDataGridView.AutoGenerateColumns = false;
            this.archivoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            this.archivoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.archivoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archivoDataGridView.DataSource = this.archivoBindingSource;
            this.archivoDataGridView.Location = new System.Drawing.Point(35, 45);
            this.archivoDataGridView.Name = "archivoDataGridView";
            this.archivoDataGridView.Size = new System.Drawing.Size(450, 243);
            this.archivoDataGridView.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Actualizar Archivo";
            // 
            // ActualizarA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(797, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.archivoDataGridView);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ActualizarA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar";
            this.Load += new System.EventHandler(this.ActualizarA_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox idArchivoTextBox;
        private System.Windows.Forms.BindingSource archivoBindingSource;
        private System.Windows.Forms.TextBox idPacienteTextBox;
        private System.Windows.Forms.TextBox pesoTextBox;
        private System.Windows.Forms.TextBox presionArterialTextBox;
        private System.Windows.Forms.TextBox temperaturaTextBox;
        private System.Windows.Forms.DataGridView archivoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Label label1;
    }
}