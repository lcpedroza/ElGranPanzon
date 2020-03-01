using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Modelo {
    public class TipoDocumento {
        public TipoDocumento(DataAccess.Tablas.TipoDocumento tipoDocumento) {
            Id = tipoDocumento.Id;
            NombreLargo = tipoDocumento.NombreLargo;
            NombreCorto = tipoDocumento.NombreCorto;
        }
        public decimal Id { get; set; }
        public string NombreLargo { get; set; }
        public string NombreCorto { get; set; }

        public DataAccess.Tablas.TipoDocumento Convertir() {
            return new DataAccess.Tablas.TipoDocumento {
                Id = Id,
                NombreLargo = NombreLargo,
                NombreCorto = NombreCorto
            };
        }
    }
}
