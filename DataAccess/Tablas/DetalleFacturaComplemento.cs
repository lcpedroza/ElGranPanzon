using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Tablas {
    public partial class DetalleFactura {

        /*
         * Autor: Juan Miguel Castro Rojas
         * Método que permite calcular el subtotal de una compra
         */
        public decimal CalcularSubtotal() {
            Subtotal = Precio * Cantidad;
            return Subtotal;
        }
    }
}
