using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoGetHospi.Controladores;
using ProyectoGetHospi.Modelos;
using ProyectoGetHospi.Entidades;

namespace ProyectoGetHospi.Vista
{
    public partial class ActualizarMed : Form
    {
        public ActualizarMed()
        {
            InitializeComponent();
        }
        CMedicos cMedico = new CMedicos();
        public void Cargardatos()
        {
            médicoBindingSource.DataSource =cMedico.Listado();
        }

        private void ActualizarMed_Load(object sender, EventArgs e)
        {
            Cargardatos();
            btnGuardarMed.Enabled = false;
            grbMedA.Enabled = false;

        }

        private void btnSeleccionMed_Click(object sender, EventArgs e)
        {
            btnGuardarMed.Enabled = true;
            grbMedA.Enabled = true;
            btnSeleccionMed.Enabled = false;
        }

        private void btnGuardarMed_Click(object sender, EventArgs e)
        {
            btnSeleccionMed.Enabled = true;
            btnGuardarMed.Enabled = false;
            médicoBindingSource.EndEdit();
            Médico M = new Médico();
            M = (Médico)médicoBindingSource.Current;
            cMedico.Actualizar(M);
            MessageBox.Show("Se han actualizado los datos del medico");
            this.Close();
        }

      
    }
}
