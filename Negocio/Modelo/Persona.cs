using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Modelo {
    public class Persona {
        public Persona() { }

        public Persona(DataAccess.Tablas.Persona persona) {
            Id = persona.Id;
            Nombres = persona.Nombres;
            Apellidos = persona.Apellidos;
            GeneroId = persona.GeneroId;
            TipoDocumentoId = persona.TipoDocumentoId;
            NumeroDocumento = persona.NumeroDocumento;
            TipoDocumento = new TipoDocumento(persona.TIPOSDOCUMENTO);
            Genero = new Genero(persona.GENEROS);
        }
        public decimal Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public decimal GeneroId { get; set; }
        public decimal TipoDocumentoId { get; set; }
        public string NumeroDocumento { get; set; }
        public Genero Genero { get; set; }
        public TipoDocumento TipoDocumento { get; set; }

        public DataAccess.Tablas.Persona Convertir() {
            return new DataAccess.Tablas.Persona {
                Id = Id,
                Nombres = Nombres,
                Apellidos = Apellidos,
                GeneroId = GeneroId,
                TipoDocumentoId = TipoDocumentoId,
                NumeroDocumento = NumeroDocumento,
            };
        }
    }
}
