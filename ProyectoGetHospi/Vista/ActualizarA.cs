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
    public partial class ActualizarA : Form
    {
        public ActualizarA()
        {
            InitializeComponent();
        }

   

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnSelecionar.Enabled = true;
            btnGuardarMed.Enabled = false;
            médicoBindingSource.EndEdit();
            Médico M = new Médico();
            M = (Médico)médicoBindingSource.Current;
            cMedico.Actualizar(M);
            MessageBox.Show("Se han actualizado los datos del medico");
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }
    }
}
