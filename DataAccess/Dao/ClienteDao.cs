using DataAccess.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dao {
    public class ClienteDao {
        private Entidades db;

        public ClienteDao(Entidades db) {
            this.db = db;
        }

        /*
       * Autor: Juan Miguel Castro Rojas
       * Método que crea un cliente
       */
        public Cliente CrearCliente(Cliente cliente) {
            db.Clientes.Add(cliente);
            db.SaveChanges();
            return cliente;
        }

        /*
       * Autor: Juan Miguel Castro Rojas
       * Método que retorna una lista de clientes
       */
        public List<Cliente> GetClientes() {
            return db.Clientes.ToList();
        }

        /*
       * Autor: Juan Miguel Castro Rojas
       * Método que retorna un cliente filtrado por Id
       */
        public Cliente GetCliente(int? id) {
            var consulta = from c in db.Clientes
                           where c.Id == id
                           select c;
            return consulta.SingleOrDefault();
        }
    }
}
