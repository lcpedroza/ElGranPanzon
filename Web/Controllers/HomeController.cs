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
                    Apellidos = Request.Form.Get("Apellidos"),
                    GeneroId = Convert.ToInt32(Request.Form.Get("generos")),
                    TipoDocumentoId = Convert.ToInt32(Request.Form.Get("tiposDeDocumento")),
                    NumeroDocumento = Request.Form.Get("numeroDocumento")
                },
                Telefono = Request.Form.Get("telefono"),
                Correo = Request.Form.Get("correo"),
            };
            var factura = (Factura)Session["factura"];
            var clienteDao = new ClienteDao(db);
            clienteDao.CrearCliente(cliente);
            factura.CLIENTES = cliente;
            Response.Redirect("/Compras/Pedidos");
            return View();
        }

        public ActionResult VerClientes() {
            var generoDao = new GeneroDao(db);
            var generos = generoDao.GetGeneros();
            var tipoDocumentoDao = new TipoDocumentoDao(db);
            var tiposDocumento = tipoDocumentoDao.GetTiposDeDocumento();

            var clienteDao = new ClienteDao(db);
            var clientes = clienteDao.GetClientes();

            ViewBag.Generos = generos;
            ViewBag.TiposDocumento = tiposDocumento;
            ViewBag.Clientes = clientes;
            return View();
        }

        public ActionResult SeleccionarCliente() {
            var factura = (Factura)Session["factura"];

            var clienteIdStr = Request.QueryString.Get("cliente");
            var clienteId = clienteIdStr == null ? null : new int?(Convert.ToInt32(clienteIdStr));
            var clienteDao = new ClienteDao(db);
            var cliente = clienteDao.GetCliente(clienteId);

            factura.CLIENTES = cliente;
            Response.Redirect("/Compras/Pedidos");
            return View();
        }
        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}