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
            btnGuardar.Enabled = false;
            grbMed.Enabled = false;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            médicoBindingSource1.MoveLast();
            médicoBindingSource1.AddNew();
            grbMed.Enabled = true;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            médicoBindingSource1.EndEdit();
            Médico M = new Médico();
            M = (Médico)médicoBindingSource1.Current;
            CMedicos cMedico = new CMedicos();
            cMedico.Registrar(M);
            this.Close();
            btnNuevo.Enabled = true;
            grbMed.Enabled = false;
            btnGuardar.Enabled = false;
            MessageBox.Show("Se ha registrado con exito al nuevo medico");
        }
    }
}
