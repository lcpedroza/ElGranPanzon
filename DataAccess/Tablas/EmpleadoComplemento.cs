using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Tablas {
    public partial class Empleado {

        /*
         * Autor: Luis Carlos Pedroza Pineda
         * Método que permite verificar un permiso
         */
        public bool VerificarPermiso(string codigoPermiso) {
            foreach (var p in ROLES.PERMISOS) {
                if (p.Codigo == codigoPermiso) {
                    return true;
                }
            }
            return false;
        }

        /*
         * Autor: Luis Carlos Pedroza Pineda
         * Método que permite verificar varios permisos
         */
        public bool VerificarCualquierPermiso(params string[] codigos) {
            foreach (var c in codigos) {
                if (VerificarPermiso(c)) {
                    return true;
                }
            }
            return false;
        }
    }
}
