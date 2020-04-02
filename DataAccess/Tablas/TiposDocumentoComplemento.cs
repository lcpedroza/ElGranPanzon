using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Tablas {
    public partial class TipoDocumento {
        /*
       * Autor: Luis Carlos Pedroza
       * Método que permite leer como String el nombre de los tipos de documentos
       */
        public override string ToString() {
            return NombreLargo;
        }
    }
}
