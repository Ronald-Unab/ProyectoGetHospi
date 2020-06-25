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

namespace ProyectoGetHospi.Vista
{
    public partial class EliminarA : Form
    {
        public EliminarA()
        {
            InitializeComponent();
        }
        CArchivos cArchivo = new CArchivos();

        private void EliminarA_Load(object sender, EventArgs e)
        {
            archivoBindingSource.DataSource = cArchivo.Listado();
        }
    }
}
