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
    
    public partial class ComidaInsumo
    {
        public decimal ComidaId { get; set; }
        public decimal InsumoId { get; set; }
        public decimal Cantidad { get; set; }
    
        public virtual Comida COMIDAS { get; set; }
        public virtual Insumo INSUMOS { get; set; }
    }
}