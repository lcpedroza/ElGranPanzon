using DataAccess.Dao;
using DataAccess.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers {
    public class HomeController : Controller {
        private Entidades db;
        public HomeController() {
            db = new Entidades();
        }
        public ActionResult Index() {
            return View();
        }
        
        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult CrearCliente() 
        {
            var generoDao = new GeneroDao(db);
            var generos = generoDao.GetGeneros();
            var tiposDocumentoDao = new TipoDocumentoDao(db);
            var tiposDocumento = tiposDocumentoDao.GetTiposDeDocumento();

            ViewBag.Generos = generos;
            ViewBag.TiposDocumento = tiposDocumento;
            return View();
        }

        public ActionResult RegistrarCliente() {
            var cliente = new Cliente {
                PERSONAS = new Persona {
                    Nombres = Request.Form.Get("Nombres"),
                    Apellidos = Request.Form.Get("primerApellido"),
                    GeneroId = Convert.ToInt32(Request.Form.Get("generos")),
                    TipoDocumentoId = Convert.ToInt32(Request.Form.Get("tiposdeDocumento")),
                    NumeroDocumento = Request.Form.Get("numeroDocumento")
                },
                Telefono = Request.Form.Get("telefono"),
                Correo = Request.Form.Get("correo"),
            };

            var clienteDao = new ClienteDao(db);
            clienteDao.CrearCliente(cliente);
            Response.Redirect("/Login/IniciarSesion");
            return View();
        }



        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}