namespace ProyectoGetHospi.Vista
{
    partial class EliminarD
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
            this.diagnosticosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosticosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // diagnosticosDataGridView
            // 
            this.diagnosticosDataGridView.AutoGenerateColumns = false;
            this.diagnosticosDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.diagnosticosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diagnosticosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.diagnosticosDataGridView.DataSource = this.diagnosticosBindingSource;
            this.diagnosticosDataGridView.Location = new System.Drawing.Point(12, 12);
            this.diagnosticosDataGridView.Name = "diagnosticosDataGridView";
            this.diagnosticosDataGridView.Size = new System.Drawing.Size(585, 264);
            this.diagnosticosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdDiagnostico";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdDiagnostico";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Diagnostico";
            this.dataGridViewTextBoxColumn2.HeaderText = "Diagnostico";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Recetas";
            this.dataGridViewTextBoxColumn3.HeaderText = "Recetas";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdConsulta";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdConsulta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // diagnosticosBindingSource
            // 
            //this.diagnosticosBindingSource.DataSource = typeof(ProyectoGetHospi.Entidades.Diagnosticos);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Eliminar Seleccionado";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EliminarD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.diagnosticosDataGridView);
            this.Name = "EliminarD";
            this.Text = "Eliminar";
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagnosticosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource diagnosticosBindingSource;
        private System.Windows.Forms.DataGridView diagnosticosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
    }
}