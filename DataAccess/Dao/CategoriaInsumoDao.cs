using DataAccess.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dao {
    public class CategoriaInsumoDao {
        private Entidades db;

        public CategoriaInsumoDao(Entidades db) {
            this.db = db;
        }

        /*
       * Autor: Juan Miguel Castro Rojas
       * Método que retorna una lista de categorías de insumos
       */
        public List<CategoriaInsumo> GetCategoriasInumo() {
            return db.CategoriasInsumos.ToList();
        }
    }
}

