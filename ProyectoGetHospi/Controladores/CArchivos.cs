using ProyectoGetHospi.Entidades;
using ProyectoGetHospi.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGetHospi.Controladores
{
    public class CArchivos
    {
        //Referencia al modelo / modelos
        MArchivos marchivos = new MArchivos();
        public void Registrar(Archivo a)
        {
            marchivos.Registrar(a);
        }

        public void Actualizar(Archivo a)
        {

        }

        public List<Archivo> Listado()
        {
            return marchivos.Listado();
        }

        public void Eliminar(int id)
        {

        }
    }
}
