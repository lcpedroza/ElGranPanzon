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

        /*
       * Autor: Juan Miguel Castro Rojas
       * Método que retorna una lista de comidas
       */
        public List<Comida> GetComidas() {
            return db.Comidas.ToList();
        }

        /*
       * Autor: Juan Miguel Castro Rojas
       * Método que retorna una lista de comidas filtrada por categoría
       */
        public List<Comida> GetComidas(decimal categoriaComidaId) {
            var consulta = from c in db.Comidas
                           where c.CategoriaId == categoriaComidaId
                           select c;
            return consulta.ToList();
        }

         /*
         * Autor: Juan Miguel Castro Rojas
         * Método que retorna una comida filtrada por Id 
         */
        public Comida GetComida(decimal id) {
            var consulta = from c in db.Comidas
                           where c.Id == id
                           select c;

            return consulta.Single();
        }
    }
}
