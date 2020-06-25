using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGetHospi.Entidades;
using ProyectoGetHospi.Controladores;
namespace ProyectoGetHospi.Vista
{
    public partial class RegistrarA : Form
    {
        public RegistrarA()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            groupBox1.Enabled = true;
            btnNuevo.Enabled = false;
        }

        private void RegistrarA_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            btnGuardar.Enabled = false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            groupBox1.Enabled = false;
            archivoBindingSource.EndEdit();
            Archivo A = new Archivo();
            A = (Archivo)archivoBindingSource.Current;
            CArchivos cArchivo = new CArchivos();
            cArchivo.Registrar(A);
            this.Close();
            MessageBox.Show("Se ha registrado con exito al nuevo usuario");

        }
    }
}
