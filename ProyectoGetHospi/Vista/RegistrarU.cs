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
using ProyectoGetHospi.Entidades;
using ProyectoGetHospi.Vista;
using ProyectoGetHospi.Controladores;

namespace ProyectoGetHospi.Vista
{
    public partial class RegistrarU : Form
    {
        public RegistrarU()
        {
            InitializeComponent();
        }


        MUsuarios mUsuarios = new MUsuarios();
        fUsuarios Fu = new fUsuarios();
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            usuariobindingSource.EndEdit();
            Usuarios U = new Usuarios();
            U = (Usuarios)usuariobindingSource.Current;
            CUsuarios cUsuarios = new CUsuarios();
            cUsuarios.Registrar(U);
            this.Close();
            btnNuevo.Enabled = true;
            grbRegistrar.Enabled = false;
            btnGuardar.Enabled = false;
            Fu.usuariosBindingSource.DataSource = mUsuarios.Listado();
            MessageBox.Show("Se ha registrado con exito al nuevo usuario");
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            usuariobindingSource.MoveLast();
            usuariobindingSource.AddNew();
            grbRegistrar.Enabled = true;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
        }

        private void RegistrarU_Load(object sender, EventArgs e)
        {
            grbRegistrar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        
    }
}
