using DataAccess.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dao {
    public class ComidaDao {

        private Entidades db;

        public ComidaDao(Entidades db) {
            this.db = db;
        }

        public List<Comida> GetComidas() {
            return db.Comidas.ToList();
        }

        public List<Comida> GetComidas(decimal categoriaComidaId) {
            var consulta = from c in db.Comidas
                           where c.CategoriaId == categoriaComidaId
                           select c;
            return consulta.ToList();
        }
        public Comida GetComida(decimal id) {
            var consulta = from c in db.Comidas
                           where c.Id == id
                           select c;

            return consulta.Single();
        }
    }
}
