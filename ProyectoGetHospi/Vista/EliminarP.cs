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
using ProyectoGetHospi.Controladores;

namespace ProyectoGetHospi.Vista
{
    public partial class EliminarP : Form
    {
        public EliminarP()
        {
            InitializeComponent();
        }
        MPaciente mPaciente = new MPaciente();
        CPaciente cPaciente = new CPaciente();
        public void Cargardatos()
        {
            pacientesBindingSource.DataSource = mPaciente.Listado();

        }
        private void EliminarP_Load(object sender, EventArgs e)
        {
            Cargardatos();
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            string Id = pacientesDataGridView.CurrentRow.Cells[0].Value.ToString();
            cPaciente.Eliminar(Convert.ToInt32(Id));
            MessageBox.Show("Se ha eliminado el paciente");
            pacientesBindingSource.DataSource = cPaciente.Listado();
        }
    }
}
