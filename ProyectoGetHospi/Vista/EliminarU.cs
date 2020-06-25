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
using ProyectoGetHospi.Controladores;

namespace ProyectoGetHospi.Vista
{
    public partial class EliminarU : Form
    {
        public EliminarU()
        {
            InitializeComponent();
        }
        CUsuarios cUsuarios = new CUsuarios();
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Id = dgvusuariosE.CurrentRow.Cells[0].Value.ToString();
            cUsuarios.Eliminar(Convert.ToInt32(Id));
            MessageBox.Show("Se ha eliminado el usuario");
            usuariosBindingSource.DataSource = cUsuarios.Listado();
        }

        private void eliminarUsuario_Load(object sender, EventArgs e)
        {
            usuariosBindingSource.DataSource = cUsuarios.Listado();
        }
    }
}
