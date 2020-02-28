
using DataAccess.Dao;
using DataAccess.Tablas;
using Negocio.Modelo;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers {
    public class OrdenesController : Controller {
        private Entidades db;

        public OrdenesController() {
            db = new Entidades();
        }

        public ActionResult Ordenes() {

            var categoriaComidaIdStr = Request.Form.Get("categoriaComida");
            var categoriaComidaId = categoriaComidaIdStr == null ? null : new int?(Convert.ToInt32(categoriaComidaIdStr));

            var categoriaComidaDao = new CategoriaComidaDao(db);
            var categoriasComidas = categoriaComidaDao.GetCategoriasComida();

            ViewBag.CategoriasComidas = categoriasComidas;
            ViewBag.CategoriaComidaId = categoriaComidaId;
            return View();
        }

        public ActionResult SeleccionarProducto() {
            
            OracleConnection con = new OracleConnection("DATA SOURCE=localhost:1521/xe; PASSWORD=12345;USER ID=SYSTEM");
            con.Open();

            OracleCommand comando = new OracleCommand("select * from CategoriasComidas", con);
            OracleDataReader lector = comando.ExecuteReader();
            if (lector.Read()){
                Console.WriteLine(lector["Nombre"].ToString());
                Console.WriteLine("Se encontraron categorias");
            } else {
                Console.WriteLine("No se encontró un nombre de rol");
            }
            return View();
        }

        public ActionResult RealizarCompra() {

            return View();
        }

        
    }
}