using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess.Tablas {
    public partial class Factura {

        /*
         * Autor: Juan Miguel Castro Rojas
         * Método que permite calcular el total de una compra recorriendo una lista
         * de detalles de factura y sumando estas mismas
         */
        public decimal TotalCompra() {

            decimal total = 0;
            foreach (var detalleFactura in DETALLEFACTURAS) {

                total += detalleFactura.Subtotal;
            }
            return total;
        }

        /*
      * Autor: luis Carlos Pedroza Pineda
      * Método que permite crear un XML de la factura
      */
        public XDocument CrearDocumentoXML() {
            var detalles = new List<XElement>();
            foreach (var df in DETALLEFACTURAS) {
                detalles.Add(
                    new XElement("Detalle", 
                        new XElement("Producto", df.COMIDAS.Nombre), 
                        new XElement("Cantidad", df.Cantidad), 
                        new XElement("Precio", df.Precio)));
            }

            XDocument miXML = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("Factura",
                                        new XAttribute("ID", Id),
                                       new XElement("Encabezado",
                                            new XElement("FechaCompra", FechaCreacion),
                                            new XElement("Total", TotalCompra())),

                                       new XElement("Empresa",
                                            new XElement("Nombre", "El Gran Panzón"),
                                            new XElement("Direccion", "Cra 50 #128 - 38"),
                                            new XElement("Ciudad", "Bogotá"),
                                            new XElement("NIT", "15448384")),

                                       new XElement("Cliente",
                                            new XElement("Nombre", CLIENTES.PERSONAS.Nombres + " " + CLIENTES.PERSONAS.Apellidos),
                                            new XElement("Identificacion", CLIENTES.PERSONAS.NumeroDocumento)),
                                       new XElement("Detalles", detalles)
                            )
                );

            return miXML;
        }
    }
}
