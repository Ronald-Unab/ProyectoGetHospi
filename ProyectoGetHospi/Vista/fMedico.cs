using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoGetHospi.Modelos;
using System.Windows.Forms;
using ProyectoGetHospi.Vista;
using ProyectoGetHospi.Controladores;

namespace ProyectoGetHospi
{
    public partial class fMedico : Form
    {
        MMedicos mMedicos = new MMedicos();
        CMedicos cMedico = new CMedicos();
        public fMedico()
        {
            InitializeComponent();
        }

        public void cargardatos()
        {
            médicoBindingSource.DataSource = cMedico.Listado();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void médicoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cargardatos();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
        }

        private void volverAlMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMenu M = new fMenu();
            M.Show();
            Hide();
        }

        private void registrarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarMed RM = new RegistrarMed();
            RM.Show();

        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarMed EM = new EliminarMed();
            EM.Show();
        }

        private void recargarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void actualizarMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarMed AM = new ActualizarMed();
            AM.Show();
        }
    }
}
