//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess.Tablas
{
    using System;
    using System.Collections.Generic;
    
    public partial class Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Persona()
        {
            this.CLIENTES = new HashSet<Cliente>();
            this.EMPLEADOS = new HashSet<Empleado>();
        }
    
        public decimal Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public decimal GeneroId { get; set; }
        public decimal TipoDocumentoId { get; set; }
        public string NumeroDocumento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente> CLIENTES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Empleado> EMPLEADOS { get; set; }
        public virtual Genero GENEROS { get; set; }
        public virtual TipoDocumento TIPOSDOCUMENTO { get; set; }
    }
}