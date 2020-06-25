using ProyectoGetHospi.Entidades;
using ProyectoGetHospi.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGetHospi.Controladores
{
    public class CDiagnosticos
    {
        //Referencia al modelo / modelos
        MDiagnosticos mdiagnostico = new MDiagnosticos();

        public void Registrar(Diagnosticos d)
        {
            mdiagnostico.Registrar(d);
        }

        public void Actualizar(Diagnosticos d)
        {

        }

        public List<Diagnosticos> Listado()
        {
            return mdiagnostico.Listado();
        }

        public void Eliminar(int id)
        {

        }
    }
}
