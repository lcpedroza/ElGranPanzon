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

        public List<CategoriaInsumo> GetCategoriasInumo() {
            return db.CategoriasInsumos.ToList();
        }
    }
}

