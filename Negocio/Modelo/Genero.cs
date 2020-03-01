using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Modelo {
    public class Genero {

        public Genero(DataAccess.Tablas.Genero genero) {
            this.Id = genero.Id;
            this.Nombre = genero.Nombre;
        }
            
        public decimal Id { get; set; }
        public string Nombre { get; set; }

        public DataAccess.Tablas.Genero Convertir() {
            return new DataAccess.Tablas.Genero {
                Id = Id,
                Nombre = Nombre
            };
        }
    }
}
