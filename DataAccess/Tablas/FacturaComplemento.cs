using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Tablas {
    public partial class Factura {
        public decimal TotalCompra() {

            decimal total = 0;
            foreach (var detalleFactura in DETALLEFACTURAS) {

                total += detalleFactura.Subtotal;
            }
            return total;
        }
    }
}
