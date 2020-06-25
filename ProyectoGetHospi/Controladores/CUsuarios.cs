using ProyectoGetHospi.Entidades;
using ProyectoGetHospi.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGetHospi.Controladores
{
    public class CUsuarios
    {
        //Referencia al modelo / modelos
        MUsuarios musuarios = new MUsuarios();

        public void Registrar(Usuarios u)
        {
            musuarios.Registrar(u);
        }

        public void Actualizar(Usuarios u)
        {
            musuarios.Actualizar(u);
        }

        public List<Usuarios> Listado()
        {
            return musuarios.Listado();
        }

        public void Eliminar(int id)
        {
            musuarios.Eliminar(id);
        }
    }
}
