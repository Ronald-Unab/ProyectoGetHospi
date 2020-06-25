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
using ProyectoGetHospi.Entidades;
namespace ProyectoGetHospi.Vista
{
    public partial class ActualizarP : Form
    {
        public ActualizarP()
        {
            InitializeComponent();
        }
        MPaciente mPaciente = new MPaciente();

        public void cargardatos()

        {
            dgvPacientes.DataSource = mPaciente.Listado();

        }
        private void ActualizarP_Load(object sender, EventArgs e)
        {
            cargardatos();
            groupBox1.Enabled = false;
            btnGuardarP.Enabled = false;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            btnSeleccionar.Enabled = false;
            btnGuardarP.Enabled = true;
            groupBox1.Enabled = true;
        }

        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            btnGuardarP.Enabled = false;
            btnSeleccionar.Enabled = true;
            cargardatos();
            pacientesBindingSource.EndEdit();
            Pacientes P = new Pacientes();
            P = (Pacientes)pacientesBindingSource.Current;
            CPaciente cPacientes = new CPaciente();
            cPacientes.Actualizar(P);
            this.Close();
            MessageBox.Show("Se han guardado los cambios");
            cargardatos();


        }
    }
}
