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

namespace ProyectoGetHospi.Vista
{
    public partial class fArchivos : Form
    {
        public fArchivos()
        {
            InitializeComponent();
        }
        MArchivos mArchivos = new MArchivos();
        public void cargardatos() 
        {
            archivoBindingSource.DataSource = mArchivos.Listado();

        }
        private void fArchivos_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void volverAlMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fMenu M = new fMenu();
            M.Show();
            Hide();
        }

        private void recargarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarA RA = new RegistrarA();
            RA.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void actualizarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarA AA = new ActualizarA();
            AA.Show();
        }

        private void eliminarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarA EA = new EliminarA();
            EA.Show();
        }

        private void recargarDatosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            fMenu M = new fMenu();
            M.Show();
            Hide();
        }

   
    }
}
