using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Modelo {
    public class Sede {
        public Sede(DataAccess.Tablas.Sede sede) {
            Id = sede.Id;
            Nombre = sede.Nombre;
            Direccion = sede.Direccion;
            Telefono = sede.Telefono;
        }
        public decimal Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
    }
}
