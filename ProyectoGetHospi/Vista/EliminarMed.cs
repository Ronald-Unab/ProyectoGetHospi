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
    public partial class EliminarMed : Form
    {
        public EliminarMed()
        {
            InitializeComponent();
        }
        CMedicos cMedico = new CMedicos();
        public void cargardatos()
        {
            médicoBindingSource.DataSource = cMedico.Listado();
        }
        private void EliminarMed_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Id = dgvMedE.CurrentRow.Cells[0].Value.ToString();
            cMedico.Eliminar(Convert.ToInt32(Id));
            MessageBox.Show("Se ha eliminado al medico");
            médicoBindingSource.DataSource = cMedico.Listado();
        }
    }
}
