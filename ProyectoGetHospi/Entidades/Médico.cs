using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ProyectoGetHospi.Entidades
{
    public class Médico
    {
        public int IdMedico { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string DUI { get; set; }
        public string Telefono { get; set; }
        public int CedulaMedico { get; set; }
    }
}
