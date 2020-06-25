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
    public partial class ActualizarU : Form
    {
        public ActualizarU()
        {
            InitializeComponent();
        }
        CUsuarios cUsuarios = new CUsuarios();
        MUsuarios mUsuarios = new MUsuarios();
        private void ActualizarU_Load(object sender, EventArgs e)
        {
            idUsuarioTextBox.Enabled = false;
            btnGuardarU.Enabled = false;
            groupBox1.Enabled = false;
            usuariosBindingSource.DataSource = mUsuarios.Listado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            groupBox1.Enabled = true;
            btnGuardarU.Enabled = true;
        }

        private void btnGuardarU_Click(object sender, EventArgs e)
        {
            usuariosBindingSource.EndEdit();
            Usuarios U = new Usuarios();
            U = (Usuarios)usuariosBindingSource.Current;
            CUsuarios cUsuarios = new CUsuarios();
            cUsuarios.Actualizar(U);
            this.Close();
            MessageBox.Show("Se han guardado los cambios");
            usuariosBindingSource.DataSource = cUsuarios.Listado();
        }
    }
}
