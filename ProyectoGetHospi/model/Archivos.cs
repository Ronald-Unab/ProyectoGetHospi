//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoGetHospi.model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Archivos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Archivos()
        {
            this.Consultas = new HashSet<Consultas>();
        }
    
        public int IdArchivo { get; set; }
        public string Peso { get; set; }
        public string PresionArterial { get; set; }
        public string Temperatura { get; set; }
        public Nullable<int> IdPaciente { get; set; }
    
        public virtual Pacientes Pacientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Consultas> Consultas { get; set; }
    }
}
