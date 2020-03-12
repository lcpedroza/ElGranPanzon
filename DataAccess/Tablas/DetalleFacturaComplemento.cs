using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Tablas {
    public partial class DetalleFactura {
        public decimal CalcularSubtotal() {
            Subtotal = Precio * Cantidad;
            return Subtotal;
        }
    }
}
