using DataAccess.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dao {
    public class TipoDocumentoDao {
        private Entidades db;

        public TipoDocumentoDao(Entidades db) {
            this.db = db;
        }

        /*
         * Autor: Luis Carlos Pedroza Pineda
         * Método que retorna una lista de tipos de documento
         */
        public List<TipoDocumento> GetTiposDeDocumento() {
            return db.TiposDocumento.ToList();
        }
    }
}
