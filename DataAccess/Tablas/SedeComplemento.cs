using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Tablas {
    public partial class Sede {

        /*
       * Autor: Luis Carlos Pedroza
       * Método que permite leer como String el nombre de las sedes
       */
        public override string ToString() {
            return Nombre;
        }
    }
}
