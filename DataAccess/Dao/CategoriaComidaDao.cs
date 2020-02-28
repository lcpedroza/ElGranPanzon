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

        public List<CategoriaComida> GetCategoriasComida() {
            return db.CategoriasComidas.ToList();
        }
    }
}
