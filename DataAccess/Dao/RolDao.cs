using DataAccess.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dao {
    public class RolDao {
        private Entidades db;

        public RolDao(Entidades db) {
            this.db = db;
        }

        /*
         * Autor: Luis Carlos Pedroza Pineda
         * Método que retorna una lista de roles
         */
        public List<Rol> GetRoles() {
            return db.Roles.ToList();
        }
    }
}
