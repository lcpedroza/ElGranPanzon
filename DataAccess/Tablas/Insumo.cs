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
    
    public partial class Insumo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Insumo()
        {
            this.COMIDAINSUMOS = new HashSet<ComidaInsumo>();
            this.INVENTARIOS = new HashSet<Inventario>();
        }
    
        public decimal Id { get; set; }
        public string Nombre { get; set; }
        public decimal CategoriaId { get; set; }
        public decimal Unidad { get; set; }
        public string Marca { get; set; }
        public string Proveedor { get; set; }
        public decimal Precio { get; set; }
    
        public virtual CategoriaInsumo CATEGORIASINSUMOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComidaInsumo> COMIDAINSUMOS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventario> INVENTARIOS { get; set; }
    }
}
