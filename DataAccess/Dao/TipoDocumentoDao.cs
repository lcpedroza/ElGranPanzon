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
      
        public List<TipoDocumento> GetTiposDeDocumento() {
            return db.TiposDocumento.ToList();
        }
    }
}
