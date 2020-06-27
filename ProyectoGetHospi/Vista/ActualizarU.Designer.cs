namespace ProyectoGetHospi.Vista
{
    partial class ActualizarU
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
            System.Windows.Forms.Label dUILabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label nITLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label direcciónLabel;
            System.Windows.Forms.Label idUsuarioLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarU));
            this.dgvUsuariosA = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.claveTextBox = new System.Windows.Forms.TextBox();
            this.direcciónTextBox = new System.Windows.Forms.TextBox();
            this.dUITextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nITTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGuardarU = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direcciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            claveLabel = new System.Windows.Forms.Label();
            dUILabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            nITLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            direcciónLabel = new System.Windows.Forms.Label();
            idUsuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosA)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // claveLabel
            // 
            claveLabel.AutoSize = true;
            claveLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            claveLabel.Location = new System.Drawing.Point(10, 209);
            claveLabel.Name = "claveLabel";
            claveLabel.Size = new System.Drawing.Size(58, 20);
            claveLabel.TabIndex = 16;
            claveLabel.Text = "Clave:";
            claveLabel.Click += new System.EventHandler(this.claveLabel_Click);
            // 
            // dUILabel
            // 
            dUILabel.AutoSize = true;
            dUILabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dUILabel.Location = new System.Drawing.Point(10, 131);
            dUILabel.Name = "dUILabel";
            dUILabel.Size = new System.Drawing.Size(40, 20);
            dUILabel.TabIndex = 20;
            dUILabel.Text = "DUI:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.Location = new System.Drawing.Point(6, 107);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(59, 20);
            fechaLabel.TabIndex = 22;
            fechaLabel.Text = "Fecha:";
            // 
            // nITLabel
            // 
            nITLabel.AutoSize = true;
            nITLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nITLabel.Location = new System.Drawing.Point(10, 159);
            nITLabel.Name = "nITLabel";
            nITLabel.Size = new System.Drawing.Size(34, 20);
            nITLabel.TabIndex = 24;
            nITLabel.Text = "NIT:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(6, 55);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(72, 20);
            nombreLabel.TabIndex = 26;
            nombreLabel.Text = "Nombre:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuarioLabel.Location = new System.Drawing.Point(10, 183);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(67, 20);
            usuarioLabel.TabIndex = 28;
            usuarioLabel.Text = "Usuario:";
            // 
            // direcciónLabel
            // 
            direcciónLabel.AutoSize = true;
            direcciónLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direcciónLabel.Location = new System.Drawing.Point(6, 81);
            direcciónLabel.Name = "direcciónLabel";
            direcciónLabel.Size = new System.Drawing.Size(84, 20);
            direcciónLabel.TabIndex = 18;
            direcciónLabel.Text = "Dirección:";
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idUsuarioLabel.Location = new System.Drawing.Point(4, 29);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(86, 20);
            idUsuarioLabel.TabIndex = 29;
            idUsuarioLabel.Text = "Id Usuario:";
            // 
            // dgvUsuariosA
            // 
            this.dgvUsuariosA.AllowUserToAddRows = false;
            this.dgvUsuariosA.AllowUserToDeleteRows = false;
            this.dgvUsuariosA.AutoGenerateColumns = false;
            this.dgvUsuariosA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuariosA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(231)))));
            this.dgvUsuariosA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuariosA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUsuariosA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(149)))), ((int)(((byte)(11)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuariosA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuariosA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direcciónDataGridViewTextBoxColumn,
            this.dUIDataGridViewTextBoxColumn,
            this.nITDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dgvUsuariosA.Cursor = System.Windows.Forms.Cursors.No;
            this.dgvUsuariosA.DataSource = this.usuariosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(220)))), ((int)(((byte)(111)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuariosA.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuariosA.EnableHeadersVisualStyles = false;
            this.dgvUsuariosA.Location = new System.Drawing.Point(16, 70);
            this.dgvUsuariosA.Name = "dgvUsuariosA";
            this.dgvUsuariosA.ReadOnly = true;
            this.dgvUsuariosA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuariosA.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuariosA.Size = new System.Drawing.Size(463, 281);
            this.dgvUsuariosA.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idUsuarioLabel);
            this.groupBox1.Controls.Add(this.idUsuarioTextBox);
            this.groupBox1.Controls.Add(claveLabel);
            this.groupBox1.Controls.Add(this.claveTextBox);
            this.groupBox1.Controls.Add(direcciónLabel);
            this.groupBox1.Controls.Add(this.direcciónTextBox);
            this.groupBox1.Controls.Add(dUILabel);
            this.groupBox1.Controls.Add(this.dUITextBox);
            this.groupBox1.Controls.Add(fechaLabel);
            this.groupBox1.Controls.Add(this.fechaDateTimePicker);
            this.groupBox1.Controls.Add(nITLabel);
            this.groupBox1.Controls.Add(this.nITTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(usuarioLabel);
            this.groupBox1.Controls.Add(this.usuarioTextBox);
            this.groupBox1.Location = new System.Drawing.Point(485, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 255);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // idUsuarioTextBox
            // 
            this.idUsuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idUsuarioTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idUsuarioTextBox.Location = new System.Drawing.Point(106, 211);
            this.idUsuarioTextBox.Name = "idUsuarioTextBox";
            this.idUsuarioTextBox.Size = new System.Drawing.Size(219, 19);
            this.idUsuarioTextBox.TabIndex = 30;
            // 
            // claveTextBox
            // 
            this.claveTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.claveTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.claveTextBox.Location = new System.Drawing.Point(106, 29);
            this.claveTextBox.Name = "claveTextBox";
            this.claveTextBox.PasswordChar = '*';
            this.claveTextBox.Size = new System.Drawing.Size(219, 19);
            this.claveTextBox.TabIndex = 17;
            // 
            // direcciónTextBox
            // 
            this.direcciónTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.direcciónTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direcciónTextBox.Location = new System.Drawing.Point(106, 55);
            this.direcciónTextBox.Name = "direcciónTextBox";
            this.direcciónTextBox.Size = new System.Drawing.Size(219, 19);
            this.direcciónTextBox.TabIndex = 19;
            // 
            // dUITextBox
            // 
            this.dUITextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dUITextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dUITextBox.Location = new System.Drawing.Point(106, 81);
            this.dUITextBox.Name = "dUITextBox";
            this.dUITextBox.Size = new System.Drawing.Size(219, 19);
            this.dUITextBox.TabIndex = 21;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(106, 107);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(219, 22);
            this.fechaDateTimePicker.TabIndex = 23;
            this.fechaDateTimePicker.Value = new System.DateTime(2020, 6, 23, 4, 2, 24, 0);
            // 
            // nITTextBox
            // 
            this.nITTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nITTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nITTextBox.Location = new System.Drawing.Point(106, 133);
            this.nITTextBox.Name = "nITTextBox";
            this.nITTextBox.Size = new System.Drawing.Size(219, 19);
            this.nITTextBox.TabIndex = 25;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombreTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(106, 159);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(219, 19);
            this.nombreTextBox.TabIndex = 27;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usuarioTextBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioTextBox.Location = new System.Drawing.Point(106, 185);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(219, 19);
            this.usuarioTextBox.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(158, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Selecionar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuardarU
            // 
            this.btnGuardarU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.btnGuardarU.FlatAppearance.BorderSize = 0;
            this.btnGuardarU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarU.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarU.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarU.Image")));
            this.btnGuardarU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarU.Location = new System.Drawing.Point(621, 367);
            this.btnGuardarU.Name = "btnGuardarU";
            this.btnGuardarU.Size = new System.Drawing.Size(99, 33);
            this.btnGuardarU.TabIndex = 19;
            this.btnGuardarU.Text = "Guardar";
            this.btnGuardarU.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarU.UseVisualStyleBackColor = false;
            this.btnGuardarU.Click += new System.EventHandler(this.btnGuardarU_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(587, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Actualizar Usuario";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataSource = typeof(ProyectoGetHospi.Entidades.Usuarios);
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "IdUsuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direcciónDataGridViewTextBoxColumn
            // 
            this.direcciónDataGridViewTextBoxColumn.DataPropertyName = "Dirección";
            this.direcciónDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direcciónDataGridViewTextBoxColumn.Name = "direcciónDataGridViewTextBoxColumn";
            this.direcciónDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dUIDataGridViewTextBoxColumn
            // 
            this.dUIDataGridViewTextBoxColumn.DataPropertyName = "DUI";
            this.dUIDataGridViewTextBoxColumn.HeaderText = "DUI";
            this.dUIDataGridViewTextBoxColumn.Name = "dUIDataGridViewTextBoxColumn";
            this.dUIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nITDataGridViewTextBoxColumn
            // 
            this.nITDataGridViewTextBoxColumn.DataPropertyName = "NIT";
            this.nITDataGridViewTextBoxColumn.HeaderText = "NIT";
            this.nITDataGridViewTextBoxColumn.Name = "nITDataGridViewTextBoxColumn";
            this.nITDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ActualizarU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(231)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(873, 434);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarU);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUsuariosA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ActualizarU";
            this.Text = "Actualizar Usuario";
            this.Load += new System.EventHandler(this.ActualizarU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUsuariosA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox claveTextBox;
        private System.Windows.Forms.TextBox dUITextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox nITTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox direcciónTextBox;
        private System.Windows.Forms.Button btnGuardarU;
        private System.Windows.Forms.TextBox idUsuarioTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direcciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
    }
}