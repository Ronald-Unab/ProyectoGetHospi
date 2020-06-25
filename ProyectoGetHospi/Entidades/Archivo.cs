using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGetHospi.Entidades
{
    public class Archivo
    {
        public int IdArchivo { get; set; }
        public string Peso { get; set; }
        public string PresionArterial { get; set; }
	    public string Temperatura { get; set; }
        public int IdPaciente { get; set; }
    }
}
