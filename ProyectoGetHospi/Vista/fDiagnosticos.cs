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
    public partial class fDiagnosticos : Form
    {
        public fDiagnosticos()
        {
            InitializeComponent();
        }
        MDiagnosticos mDiagnosticos = new MDiagnosticos();
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            fMenu M = new fMenu();
            M.Show();
            Hide();
        }

        private void fDiagnosticos_Load(object sender, EventArgs e)
        {
            diagnosticoBindingSource.DataSource = mDiagnosticos.Listado();
        }

        private void nuevoDiagnosticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarD RD = new RegistrarD();
            RD.Show();
        }

        private void actualizarDiagnosticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarD AD = new ActualizarD();
            AD.Show();
        }

        private void eliminarDiagnosticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarD ED = new EliminarD();
            ED.Show();
        }

    }
}
