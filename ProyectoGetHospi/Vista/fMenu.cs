using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGetHospi.Vista
{
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }

        private void btnMedicosM(object sender, EventArgs e)
        {
            fMedico fm = new fMedico();
            fm.Show();
            Hide();
        }

        private void btnUsuarios(object sender, EventArgs e)
        {
            fUsuarios fu = new fUsuarios();
            fu.Show();
            Hide();  
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            fPacientes fp = new fPacientes();
            fp.Show();
            Hide();
        }

        private void btnArchivos_Click(object sender, EventArgs e)
        {
            fArchivos fa = new fArchivos();
            fa.Show();
            Hide();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            fConsulta fc = new fConsulta();
            fc.Show();
            Hide();
        }

        private void btnDiagnostico_Click(object sender, EventArgs e)
        {
            fDiagnosticos fd = new fDiagnosticos();
            fd.Show();
            Hide();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            fEspecialidades fe = new fEspecialidades();
            fe.Show();
            Hide();
        }
    }
}
