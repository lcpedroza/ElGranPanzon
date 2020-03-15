using DataAccess.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dao {
    class SedeDao {
        private Entidades db;

        public SedeDao(Entidades db) {
            this.db = db;
        }

        public List<Sede> GetSedes() {
            return db.Sedes.ToList();
        }
    }
}

