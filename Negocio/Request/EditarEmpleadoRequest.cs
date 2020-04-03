using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Request {
   public class EditarEmpleadoRequest {

        public int EmpleadoId { get; set; }
        
        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string GeneroId { get; set; }

        public string TiposdeDocumentoId { get; set; }

        public string RolId { get; set; }

        public string numeroDocumento { get; set; }

        public string telefono { get; set; }

        public decimal salario { get; set; }

        public string correo { get; set; }

        public string clave { get; set; }

}
}
