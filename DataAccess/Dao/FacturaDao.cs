using DataAccess.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dao {
    public class FacturaDao {
        private Entidades db;
        public FacturaDao(Entidades db) {
            this.db = db;
        }
        /*
         * Autor: Luis Carlos Pedroza Pineda
         * Método que crea la factura
         */
        public Factura crearFactura(Factura factura) {
            var detallesFacturas = new List<DetalleFactura>();
            foreach (var df in factura.DETALLEFACTURAS) {
                var detalleFactura = new DetalleFactura {
                    ComidaId = df.COMIDAS.Id,
                    Cantidad = df.Cantidad,
                    Precio = df.Precio,
                    Subtotal = df.Subtotal
                };
                detallesFacturas.Add(detalleFactura);
            }

            factura.FechaCreacion = DateTime.Now;

            var f = new Factura {
                FechaCreacion = factura.FechaCreacion,
                ClienteId = factura.CLIENTES.Id,
                Total = factura.Total,
                SedeId = factura.SEDES.Id,
                DETALLEFACTURAS = detallesFacturas
            };

            db.Facturas.Add(f);
            db.SaveChanges();
            factura.Id = f.Id;
            return f;
        }

        public List<Factura> GetFacturas(Sede s) {
            var consulta = from f in db.Facturas
                           orderby f.FechaCreacion descending
                           where f.SEDES.Id == s.Id
                           select f;
            return consulta.ToList();
        }
    }
}
