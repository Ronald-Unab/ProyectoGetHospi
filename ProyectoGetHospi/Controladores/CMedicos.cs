using ProyectoGetHospi.Entidades;
using ProyectoGetHospi.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGetHospi.Controladores
{
    public class CMedicos
    {
        //Referencia al modelo / modelos
        MMedicos mmedicos = new MMedicos();

        public void Registrar(Médico m)
        {
            mmedicos.Registrar(m);
        }

        public void Actualizar(Médico m)
        {
            mmedicos.Actualizar(m);
        }

        public List<Médico> Listado()
        {
            return mmedicos.Listado();
        }

        public void Eliminar(int id)
        {
            mmedicos.Eliminar(id);
        }
    }
}
