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
    public partial class fEspecialidades : Form
    {
        public fEspecialidades()
        {
            InitializeComponent();
        }
        MEspecialidades mEspecialidades = new MEspecialidades();
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            fMenu M = new fMenu();
            M.Show();
            Hide();
        }

        private void fEspecialidades_Load(object sender, EventArgs e)
        {
            especialidadesBindingSource.DataSource = mEspecialidades.Listado();
        }
    }
}
