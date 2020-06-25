using ProyectoGetHospi.Entidades;
using ProyectoGetHospi.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGetHospi.Controladores
{
    public class CPaciente
    {
        //Referencia al modelo / modelos
        MPaciente mpacientes = new MPaciente(); 

        public void Registrar(Pacientes p)
        {
            mpacientes.Registrar(p);
        }

        public void Actualizar(Pacientes p)
        {

        }

        public List<Pacientes> Listado()
        {
            return mpacientes.Listado();
        }

        public void Eliminar(int id)
        {
            mpacientes.Eliminar(id);
        }
    }
}
