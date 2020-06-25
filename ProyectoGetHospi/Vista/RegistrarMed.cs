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


namespace ProyectoGetHospi.Vista
{
    public partial class RegistrarMed : Form
    {
        public RegistrarMed()
        {
            InitializeComponent();
        }

        private void RegistrarMed_Load(object sender, EventArgs e)
        {
            btnGuardarMed.Enabled = false;
            grbMed.Enabled = false;
        }

        private void btnGuardarMed_Click(object sender, EventArgs e)
        {
            médicoBindingSource.EndEdit();
            Médico M = new Médico();
            M = (Médico)médicoBindingSource.Current;
            CMedicos cMedico = new CMedicos();
            cMedico.Registrar(M);
            this.Close();
            btnNuevoMed.Enabled = true;
            grbMed.Enabled = false;
            btnGuardarMed.Enabled = false;
            MessageBox.Show("Se ha registrado con exito al nuevo medico");
        }

        private void btnNuevoMed_Click(object sender, EventArgs e)
        {
            médicoBindingSource.MoveLast();
            médicoBindingSource.AddNew();
            grbMed.Enabled = true;
            btnGuardarMed.Enabled = true;
            btnNuevoMed.Enabled = false;
        }
    }
}
