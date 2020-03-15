using DataAccess.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dao {
    public class InventarioDao {
        private Entidades db;

        public InventarioDao(Entidades db) {
            this.db = db;
        }

        public Inventario CrearInventario(Inventario i) {

            var inventario = new Inventario {
                FechaCreacion = DateTime.Now,
                InsumoId = i.InsumoId,
                SedeId = i.SedeId,
                MovimientoCantidad = i.MovimientoCantidad
            };
            db.Inventarios.Add(inventario);
            db.SaveChanges();
            return i;
        }
    }
}

