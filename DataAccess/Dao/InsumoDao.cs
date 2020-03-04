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

        public Insumo CrearInsumo(Insumo i)
        {
            i.FechaCreacion = DateTime.Now;
            db.Insumos.Add(i);
            db.SaveChanges();
            return i;
        }
    }
}
