using DataAccess.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dao
{
   public  class InsumoDao
    {
        private Entidades db;

        public InsumoDao(Entidades db)
        {
            this.db = db;
        }

        /*
         * Autor: Juan Miguel Castro Rojas
         * Método que retorna una lista de insumos y la ordena de forma ascendente
         */
        public List<Insumo> GetInsumos()
        {
            var consulta = from i in db.Insumos
                         orderby i.Nombre ascending
                         select i;
            return consulta.ToList();
        }
    }
}
