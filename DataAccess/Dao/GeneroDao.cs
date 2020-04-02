using DataAccess.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dao {
    public class GeneroDao {
        private Entidades db;

        public GeneroDao(Entidades db) {
            this.db = db;
        }
        /*
         * Autor: Luis Carlos Pedroza Pineda
         * Método que retorna una lista de géneros
         */
        public List<Genero> GetGeneros() {
            return db.Generos.ToList();
        }
    }
}
