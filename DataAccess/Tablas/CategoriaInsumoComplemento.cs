using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Tablas {
    public partial class CategoriaInsumo {

        /*
          * Autor: Juan Miguel Castro Rojas
          * Método que permite leer como String el nombre de las categorías de insumo
          */
        public override string ToString() {
            return Nombre;
        }
    }
}
