using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGetHospi.Entidades
{
    public class Pacientes
    {
		public int IdPaciente { get; set; }
		public int CédulaPaciente { get; set; }
		public int NumRegistro { get; set; }
		public string Nombre { get; set; }
		public string Dirección { get; set; }
		public string Telefono { get; set; }
		public DateTime FechaNcimiento { get; set; }
		public string Sexo { get; set; }
		public string NombrePadre { get; set; }
		public string NombreMadre { get; set; }
		public string GrupoSanguineo { get; set; }

	}
}
