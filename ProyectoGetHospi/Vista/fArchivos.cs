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
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
        }

        private void fArchivos_Load(object sender, EventArgs e)
        {
            archivoBindingSource.DataSource = mArchivos.Listado();
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
    }
}
