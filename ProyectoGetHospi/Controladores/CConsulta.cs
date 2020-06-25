using ProyectoGetHospi.Entidades;
using ProyectoGetHospi.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGetHospi.Controladores
{
    public class CConsulta
    {
        //Referencia al modelo / modelos
        MConsulta mconsultas = new MConsulta();

        public void Registrar(Consultas c)
        {
            mconsultas.Registrar(c);
        }

        public void Actualizar(Consultas c)
        {

        }

        public List<Consultas> Listado()
        {
            return mconsultas.Listado();
        }

        public void Eliminar(int id)
        {

        }
    }
}
