using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ProyectoGetHospi.Entidades;
using ProyectoGetHospi.Modelos;
using ProyectoGetHospi.Vista;
using ProyectoGetHospi.model;

namespace ProyectoGetHospi
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            using (GetHospiEntities4 db = new GetHospiEntities4())
            {
                var lista = from usuario in db.Usuarios
                            where usuario.Usuario == txtUsuario.Text
                            && usuario.Clave == txtClave.Text
                            select usuario;

                if (lista.Count() > 0)
                {
                    fMenu menu = new fMenu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(" ¡El Usuario y/o clave no son corecctos! " + "  ¡Intente de nuevo! ");
                    txtUsuario.Clear();
                    txtClave.Clear();
                    txtUsuario.Focus();
                }
            }
        }
    }
}


