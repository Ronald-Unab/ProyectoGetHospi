using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGetHospi.Entidades;
using ProyectoGetHospi.Controladores;
using ProyectoGetHospi.Modelos;

namespace ProyectoGetHospi.Vista
{
    public partial class RegistrarP : Form
    {
        public RegistrarP()
        {
            InitializeComponent();
        }

        private void RegistrarP_Load(object sender, EventArgs e)
        {
            btnGuardarP.Enabled = false;
            grbRegistrarP.Enabled = false;
        }


        private void btnNuevoP_Click(object sender, EventArgs e)
        {
            btnNuevoP.Enabled = false;
            btnGuardarP.Enabled = true;
            grbRegistrarP.Enabled = true;
        }

        private void btnGuardarP_Click(object sender, EventArgs e)
        {
            pacientesBindingSource.EndEdit();
            Pacientes P = new Pacientes();
            P = (Pacientes)pacientesBindingSource.Current;
            CPaciente cPaciente = new CPaciente();
            cPaciente.Registrar(P);
            this.Close();
            btnGuardarP.Enabled = false;
            grbRegistrarP.Enabled = false;
            btnNuevoP.Enabled = true;
            MessageBox.Show("Se ha registrado al nuevo paciente");
        }
    }
}
