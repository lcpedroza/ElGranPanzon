using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Modelo {
    public class Rol {
        public Rol(DataAccess.Tablas.Rol rol) {
            Id = rol.Id;
            Nombre = rol.Nombre;
        }
        public decimal Id { get; set; }
        public string Nombre { get; set; }
    }
}
