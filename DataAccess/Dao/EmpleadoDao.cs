using DataAccess.Tablas;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Dao {
   public class EmpleadoDao {
        private Entidades db;

        public EmpleadoDao(Entidades db) {
            this.db = db;
        }

          /*
          * Autor: luis Carlos Pedroza Pineda
          * Método que realiza logueo buscando un empleado por correo y contraseña
          */
        public Empleado Login(string correo, string clave) {
            var consulta = from e in db.Empleados
                           where e.Correo == correo && e.Clave == clave
                           select e;

            return consulta.SingleOrDefault();
        }

        /*
          * Autor: luis Carlos Pedroza Pineda
          * Método que crea un empleado
          */
        public Empleado CrearEmpleado(Empleado empleado) {
            empleado.FechaCreacion = DateTime.Now;
            db.Empleados.Add(empleado);
            db.SaveChanges();
            return empleado;
        }

        /*
          * Autor: luis Carlos Pedroza Pineda
          * Método que edita un empleado
          */
        public Empleado EditarEmpleado(Empleado empleado) {
            db.SaveChanges();
            return empleado;
        }

        /*
          * Autor: luis Carlos Pedroza Pineda
          * Método que elimina un empleado filtrado por Id
          */
        public bool EliminarEmpleado(Empleado empleado) {
            var consulta = from e in db.Empleados
                           where e.Id == empleado.Id
                           select e;
            var emp = consulta.Single();
            db.Entry(emp.PERSONAS).State = EntityState.Deleted;
            db.Entry(emp).State = EntityState.Deleted;  
            db.SaveChanges();
            return true;
        }

        /*
          * Autor: luis Carlos Pedroza Pineda
          * Método que retorna una lista de empleados
          */
        public List<Empleado> GetEmpleados() {
            return db.Empleados.ToList();
        }

        /*
          * Autor: luis Carlos Pedroza Pineda
          * Método que retorna un empleado filtrado por Id
          */
        public Empleado GetEmpleado(int? id) {
            var consulta = from e in db.Empleados
                           where e.Id == id
                           select e;
            return consulta.SingleOrDefault();
        }
    }
}
