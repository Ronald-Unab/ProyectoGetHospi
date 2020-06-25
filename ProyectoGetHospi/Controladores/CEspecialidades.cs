using ProyectoGetHospi.Entidades;
using ProyectoGetHospi.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGetHospi.Controladores
{
    public class CEspecialidades
    {
        //Referencia al modelo / modelos
        MEspecialidades mespecialidades = new MEspecialidades();

        public void Registrar(Especialidades e)
        {
            mespecialidades.Registrar(e);
        }

        public void Actualizar(Especialidades e)
        {

        }

        public List<Especialidades> Listado()
        {
            return mespecialidades.Listado();
        }

        public void Eliminar(int id)
        {

        }
    }
}
