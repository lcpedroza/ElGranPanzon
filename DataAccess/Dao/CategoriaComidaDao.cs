using DataAccess.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dao {
    public class CategoriaComidaDao {
        private Entidades db;

        public CategoriaComidaDao(Entidades db) {
            this.db = db;
        }

        /*
        * Autor: Juan Miguel Castro Rojas
        * Método que retorna una lista de categorías de comidas
        */
        public List<CategoriaComida> GetCategoriasComida() {
            return db.CategoriasComidas.ToList();
        }
    }
}
