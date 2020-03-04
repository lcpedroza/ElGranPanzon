using Negocio.Modelo;
using DataAccess.Dao;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using DataAccess.Tablas;

namespace Web.Controllers {
    public class AdministrarController : Controller {
        private DataAccess.Tablas.Entidades db;

        public AdministrarController() {
            db = new DataAccess.Tablas.Entidades();
        }

        public ActionResult CrearEmpleado() {
            var generoDao = new GeneroDao(db);
            var generos = generoDao.GetGeneros();
            var rolDao = new RolDao(db);
            var roles = rolDao.GetRoles();
            var tipoDocumentoDao = new TipoDocumentoDao(db);
            var tiposDocumento = tipoDocumentoDao.GetTiposDeDocumento();

            ViewBag.Generos = generos;
            ViewBag.Roles = roles;
            ViewBag.TiposDocumento = tiposDocumento;

            return View();
        }
        
        public ActionResult RegistrarEmpleado() {
            var empleadoLogueado = (Empleado)Session["empleado"];

            var empleado = new Empleado {
                Persona = new Persona {
                    Nombres = Request.Form.Get("Nombres"),
                    Apellidos = Request.Form.Get("Apellidos"),
                    GeneroId = Convert.ToInt32(Request.Form.Get("generos")),
                    TipoDocumentoId = Convert.ToInt32(Request.Form.Get("tiposdeDocumento")),
                    NumeroDocumento = Request.Form.Get("numeroDocumento"),
        },
                SedeId = empleadoLogueado.SedeId,
                RolId = Convert.ToInt32(Request.Form.Get("roles")),
                FechaContratacion = Convert.ToDateTime(Request.Form.Get("fechaContratacion")),
                Telefono = Request.Form.Get("telefono"),
                Salario = Convert.ToInt32(Request.Form.Get("salario")),
                Correo = Request.Form.Get("correo"),
                Clave = Request.Form.Get("clave")
        };


            var empleadoDao = new EmpleadoDao(db);
            empleadoDao.CrearEmpleado(empleado.Convertir());
            Response.Redirect("/Home/Index");
            return View();
        }

        public ActionResult VerEmpleados() {
            var generoDao = new GeneroDao(db);
            var generos = generoDao.GetGeneros();
            var rolDao = new RolDao(db);
            var roles = rolDao.GetRoles();
            var tipoDocumentoDao = new TipoDocumentoDao(db);
            var tiposDocumento = tipoDocumentoDao.GetTiposDeDocumento();
          
            var empleadoDao = new EmpleadoDao(db);
            var empleados = empleadoDao.GetEmpleados();

            ViewBag.Generos = generos;
            ViewBag.Roles = roles;
            ViewBag.TiposDocumento = tiposDocumento;
            ViewBag.Empleados = empleados;
            return View();
        }

        public ActionResult EliminarEmpleado() {
            var empleadoIdStr = Request.QueryString.Get("empleado"); 
            var empleadoId = empleadoIdStr == null ? null : new int?(Convert.ToInt32(empleadoIdStr));
            var empleadoDao = new EmpleadoDao(db);
            var empleado = empleadoDao.GetEmpleado(empleadoId);
            empleadoDao.EliminarEmpleado(empleado);

            Response.Redirect("/Administrar/VerEmpleados");
            return View();
        }

        public ActionResult EditarEmpleado() {

            return View();
           
        }

        public ActionResult CrearProducto()
        {
            var categoriaInsumoDao = new CategoriaInsumoDao(db);
            var categoriasInsumo = categoriaInsumoDao.GetCategoriasInumo();
            ViewBag.Categorias = categoriasInsumo;
            return View();

        }

        public ActionResult AgregarProducto() {
            var empleadoLogueado = (Empleado)Session["empleado"];

            var insumo = new Insumo();



            insumo.Nombre = Request.Form.Get("Nombre");
            insumo.Marca = Request.Form.Get("Marca");
            insumo.CategoriaId = Convert.ToInt32(Request.Form.Get("categorias"));
            insumo.Proveedor = Request.Form.Get("Provedor");
            insumo.Precio = Convert.ToInt32(Request.Form.Get("Precio"));
            insumo.FechaCompra = Convert.ToDateTime(Request.Form.Get("fechaCompra"));
            insumo.FechaVencimiento = Convert.ToDateTime(Request.Form.Get("fechaVencimiento"));

            
            var insumoDao = new InsumoDao(db);
            insumoDao.CrearInsumo(insumo);
            Response.Redirect("/Home/Index");
            return View();
        }
    }
}