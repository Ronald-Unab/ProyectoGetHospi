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
    public partial class fConsulta : Form
    {
        public fConsulta()
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
    }
}
