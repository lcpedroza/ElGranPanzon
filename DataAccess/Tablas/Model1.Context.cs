﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entidades : DbContext
    {
        public Entidades()
            : base("name=Entidades")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CategoriaComida> CategoriasComidas { get; set; }
        public virtual DbSet<CategoriaInsumo> CategoriasInsumos { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Comida> Comidas { get; set; }
        public virtual DbSet<DetalleFactura> DetallesFactura { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Genero> Generos { get; set; }
        public virtual DbSet<Insumo> Insumos { get; set; }
        public virtual DbSet<Inventario> Inventarios { get; set; }
        public virtual DbSet<Permiso> Permisos { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Rol> Roles { get; set; }
        public virtual DbSet<Sede> Sedes { get; set; }
        public virtual DbSet<TipoDocumento> TiposDocumento { get; set; }
        public virtual DbSet<ComidaInsumo> ComidaInsumos { get; set; }
    }
}
