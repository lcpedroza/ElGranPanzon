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
    
    public partial class Cliente
    {
        public decimal Id { get; set; }
        public decimal PersonaId { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
    
        public virtual Persona PERSONAS { get; set; }
    }
}