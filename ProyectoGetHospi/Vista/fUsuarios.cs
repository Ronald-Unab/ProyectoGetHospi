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
    public partial class fUsuarios : Form
    {
        MUsuarios mUsuarios = new MUsuarios();
        
        public fUsuarios()
        {
            InitializeComponent();
        }
        public void cargardatos ()
        {
            usuariosBindingSource.DataSource = mUsuarios.Listado();
        }
     
        private void fUsuarios_Load(object sender, EventArgs e)
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
            RegistrarU RU = new RegistrarU();
            RU.Show();
        }

        private void btnRecargarU_Click(object sender, EventArgs e)
        {
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarU EU = new EliminarU();
            EU.Show();
        }

        private void actualizarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarU AU = new ActualizarU();
            AU.Show();
        }

        private void recargarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usuariosBindingSource.DataSource = mUsuarios.Listado();
        }
    }
}
