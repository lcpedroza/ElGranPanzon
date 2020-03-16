using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Tablas {
    public partial class Insumo {
        public override string ToString() {
            return Nombre;
        }

        public decimal GetCantidad(Sede s) {
            
            return INVENTARIOS.Where(i=>i.SedeId == s.Id).Select(i => i.MovimientoCantidad).Sum();
        }

        public decimal GetCantidadGeneral() {

            return INVENTARIOS.Select(i => i.MovimientoCantidad).Sum();
        }
    }
}
