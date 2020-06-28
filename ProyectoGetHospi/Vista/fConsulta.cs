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
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }
        MConsulta mConsulta = new MConsulta();

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            fMenu M = new fMenu();
            M.Show();
            Hide();
        }

        private void fConsulta_Load(object sender, EventArgs e)
        {
            consultasBindingSource.DataSource = mConsulta.Listado();
        }

        private void registrarConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarC RC = new RegistrarC();
            RC.Show();
        }

        private void actualizarConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarC AC = new ActualizarC();
            AC.Show();
        }

        private void eliminarConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarC EC = new EliminarC();
            EC.Show();
        }
    }
}
