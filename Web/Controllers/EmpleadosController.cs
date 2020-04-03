using DataAccess.Dao;
using DataAccess.Tablas;
using Negocio.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web.Controllers
{
    public class EmpleadosController : ApiController{

        private Entidades db;

        public EmpleadosController() {
             db = new Entidades();
        }

        public IHttpActionResult Put(int id, EditarEmpleadoRequest editarEmpleado) {

            var empleadoDao = new EmpleadoDao(db);
            var empleado = empleadoDao.GetEmpleado(id);

            empleado.PERSONAS.Nombres = editarEmpleado.Nombres;
            empleado.PERSONAS.Apellidos = editarEmpleado.Apellidos;
            empleado.PERSONAS.GeneroId = Convert.ToInt32(editarEmpleado.GeneroId);
            Console.WriteLine("la id del genero es: " + editarEmpleado.GeneroId);


            empleado.PERSONAS.TipoDocumentoId = Convert.ToInt32(editarEmpleado.TiposdeDocumentoId);
            Console.WriteLine("la id del td es: " + editarEmpleado.TiposdeDocumentoId);

            empleado.PERSONAS.NumeroDocumento = editarEmpleado.numeroDocumento;

            empleado.RolId = Convert.ToInt32(editarEmpleado.RolId);
            Console.WriteLine("la id del rol es: " + editarEmpleado.RolId);


            empleado.Telefono = editarEmpleado.telefono;
            empleado.Salario = editarEmpleado.salario;
            empleado.Correo = editarEmpleado.correo;
            empleado.Clave = editarEmpleado.clave;

            empleadoDao.EditarEmpleado(empleado);


            return Ok("Empleado editado correctamente");
        }


    }
}
