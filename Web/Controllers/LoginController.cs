
using DataAccess.Dao;
using DataAccess.Tablas;
using Negocio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class LoginController : Controller {
        private Entidades db;

        public enum TipoSesion {
            Empleado,
            Cliente
        }

        public LoginController() {
            db = new Entidades();
        }

        // GET: Login
        public ActionResult Index() {
            return View();
        }

        public ActionResult IniciarSesion() {

            var correo = Request.Form.Get("correo");
            var clave = Request.Form.Get("clave");

            if (correo != null && clave != null) {
                var empleadoDao = new EmpleadoDao(db);
                var empleado = empleadoDao.Login(correo, clave);

                if (empleado != null) {
                    Session["empleado"] = empleado;
                    Response.Redirect("/Home/Index");
                } else {
                    TempData["Mensaje"] = "Correo o contraseña incorrecta";
                    ViewBag.Correo = correo;
                }
            }

            return View();
        }

        public ActionResult CerrarSesion() {
            if (Session["empleado"] != null) {
                Session["empleado"] = null;
            }

            Response.Redirect("/Home/Index");
            return View();
        }
    }
}