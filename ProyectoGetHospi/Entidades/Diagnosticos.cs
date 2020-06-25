using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGetHospi.Entidades
{
    public class Diagnosticos
    {
        public int IdDiagnostico { get; set; }
        public string Diagnostico { get; set; }
        public string Recetas { get; set; }
        public int IdConsulta { get; set; }
    }
}
