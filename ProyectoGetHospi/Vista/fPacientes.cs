using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGetHospi.Modelos;
using ProyectoGetHospi.Vista;

namespace ProyectoGetHospi.Vista
{
    public partial class fPacientes : Form
    {
        public fPacientes()
        {
            
            InitializeComponent();
        }
        MPaciente mPaciente = new MPaciente();
        public void Cargardatos()

        {
            pacientesBindingSource.DataSource = mPaciente.Listado();
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
         
        }

        private void fPacientes_Load(object sender, EventArgs e)
        {
            Cargardatos();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarP RP = new RegistrarP();
            RP.Show();
        }

        private void actualizarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarP AP = new ActualizarP();
            AP.Show();
        }

        private void eliminarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarP EP = new EliminarP();
            EP.Show();
        }

        private void volverAlMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMenu M = new fMenu();
            M.Show();
            Hide();
        }

        private void recargarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargardatos();
        }
    }
}
