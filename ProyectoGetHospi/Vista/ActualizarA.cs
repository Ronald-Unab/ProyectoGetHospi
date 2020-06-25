using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGetHospi.Controladores;
using ProyectoGetHospi.Modelos;
using ProyectoGetHospi.Entidades;

namespace ProyectoGetHospi.Vista
{
    public partial class ActualizarA : Form
    {
        public ActualizarA()
        {
            InitializeComponent();
        }
        public void cargardatos() 
        {
            archivoBindingSource.DataSource = mArchivo.Listado();
        }
        MArchivos mArchivo = new MArchivos();
        CArchivos cArchivo = new CArchivos();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnSeleccionar.Enabled = true;
            btnGuardar.Enabled = false;
            archivoBindingSource.EndEdit();
            Archivo archivo = new Archivo();
            archivo = (Archivo)archivoBindingSource.Current;
            cArchivo.Actualizar(archivo);
            MessageBox.Show("Los datos del archivo se han actualizado");
            cargardatos();
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            btnSeleccionar.Enabled = false;
            groupBox1.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void ActualizarA_Load(object sender, EventArgs e)
        {
            cargardatos();
            groupBox1.Enabled = false;
            btnGuardar.Enabled = false;
        }
    }
}
